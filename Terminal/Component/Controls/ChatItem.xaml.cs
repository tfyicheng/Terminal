using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Terminal.Library;
using Terminal.Library.ResultModel;
using Terminal.Library.Service;
using Terminal.Library.ViewModel;
using  static Terminal.Common.ClassHelper;

namespace Terminal.Component.Controls
{
    /// <summary>
    /// ChatItem.xaml 的交互逻辑
    /// </summary>
    public partial class ChatItem : UserControl
    {
        private readonly ScrollViewer scroll;
        private ChatColumnInfoModel chatColumn;
        private static Border borderSelect;
        public MasterChat MasterChat { get; private set; } = new MasterChat();//创建聊天窗口对象
        public ChatItem()
        {
            InitializeComponent();
            //scroll.ScrollChanged += Scroll_ScrollChanged;
            MasterChat.Loaded += MasterChat_Loaded; 
            txbNickName.SetBinding(Run.TextProperty, "NickName");//绑定用户名
            txbRemarkName.SetBinding(Run.TextProperty, "RemarkName");
            //brdBadge.SetBinding(VisibilityProperty, new Binding { Path = new PropertyPath("Unread"), Converter = FindResource<BoolVisibilityConvert>("BoolVisibilityConvert") });
            txbBadgeNumber.SetBinding(TextBlock.TextProperty, "Unread");

            MasterChat.itcMasterChat.SetBinding(ItemsControl.ItemsSourceProperty, "ChatContent");//把聊天内容绑定到聊天框子控件中
            MasterChat.brdUnread.IsVisibleChanged += BrdUnread_IsVisibleChanged;
            MasterChat.Loaded += MasterChat_Loaded;

            MasterChat.itcMasterChat.ApplyTemplate();
            scroll = MasterChat.itcMasterChat.Template.FindName("sclItems", MasterChat.itcMasterChat) as ScrollViewer;
            scroll.ScrollChanged += Scroll_ScrollChanged;
        }

        //列表控件加载事件
        private void UserControlMain_Loaded(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ChatFriendID))
            {
                ChatFriendID = chatColumn.FriendID;
            }
            if (chatColumn.FriendID == ChatFriendID)
            {
                if (brdChat != borderSelect)
                {
                    brdChat.IsEnabled = false;
                    if (borderSelect != null)
                    {
                        borderSelect.IsEnabled = true;
                    }
                    borderSelect = brdChat;
                    TransferringData(typeof(ChatMain), DataPassingType.SelectMessage, this);
                }
            }
        }

        //对话框控件加载事件，有未读消息拉到底并把读取消息放到线程池
        private void MasterChat_Loaded(object sender, RoutedEventArgs e)
        {
            if (MasterChat.itcMasterChat.Tag == null || chatColumn.Unread > 0)
            {
                if (MasterChat.brdUnread.Visibility == Visibility.Collapsed && chatColumn.Unread > 0)
                {
                    ThreadPool.QueueUserWorkItem(ReadMessage);
                }
                //scroll.ScrollToEnd();
                MasterChat.itcMasterChat.Tag = true;
            }
        }

        //聊天框滚动事件，滚到底部取消未读框
        private void Scroll_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            if (scroll.VerticalOffset > scroll.ScrollableHeight - 50)
            {
                MasterChat.brdUnread.Visibility = Visibility.Collapsed;
            }
        }



        //当此元素的数据上下文更改时发生
        private void UserControlMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is ChatColumnInfoModel chatColumnInfo)
            {
                chatColumn = chatColumnInfo;
                chatColumn.ChatContent = new ObservableCollection<ChatMessagesModel>();
                chatColumn.ChatContent.CollectionChanged += ChatContent_CollectionChanged;

                MasterChat.DataContext = chatColumn;
                //根据传入不同的id去加载聊天记录
                ThreadPool.QueueUserWorkItem(Load, chatColumnInfo.ChatID);
            }
        }
        //加载事件  获取聊天记录
        private void Load(object data)
        {
            lock (chatColumn.ChatContent)
            {
                if (chatColumn.ChatContent.Count == 0)
                {
                    if (ChatService.GetChattingRecords(data.ToString(), out List<ChatMessagesModel> chatMessages))//拿到消息记录的集合
                    {
                        Dispatcher.Invoke(delegate
                        {
                            foreach (ChatMessagesModel item in chatMessages) //遍历集合添加给chatcontent，这里chatcolu仍归属同一个对象
                            {
                                chatColumn.ChatContent.Add(item);
                            }
                        });
                        chatColumn.Unread = chatMessages.Where(item => item.ReceiverID == UserID && !item.IsRead && !item.IsWithdraw).Count();
                        Dispatcher.Invoke(delegate
                        {
                            if (MasterChat.IsLoaded)
                            {
                                scroll.ScrollToEnd();
                                if (chatColumn.Unread > 0)
                                {
                                    ThreadPool.QueueUserWorkItem(ReadMessage);
                                }
                            }
                        });
                    }
                }
            }
        }

        //更新消息列表最后一条消息和时间
        private void ChatContent_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (chatColumn.ChatContent.LastOrDefault() is ChatMessagesModel chatMessages)
            {
                switch (chatMessages.MessageType)
                {
                    case MessageType.Text:
                        txbLastMessage.Text = chatMessages.MessageContent.Replace("\r\n", string.Empty);
                        break;
                    case MessageType.RichText:
                        txbLastMessage.Text = $"[{FindResource<string>("RichMessage")}]";
                        break;
                    case MessageType.Voice:
                        txbLastMessage.Text = $"[{FindResource<string>("VoiceMessage")}]";
                        break;
                    case MessageType.File:
                        {
                            FileModel fileModel = JsonConvert.DeserializeObject<FileModel>(chatMessages.MessageContent);
                            txbLastMessage.Text = fileModel.FileType == FileType.Image
                                ? $"[{FindResource<string>("ImageMessage")}]"
                                : $"[{FindResource<string>("AccessoryMessage")}]";
                        }
                        break;
                    case MessageType.VoiceTalk:
                        txbLastMessage.Text = $"[{FindResource<string>("VoiceTalk")}]";
                        break;
                    case MessageType.VideoTalk:
                        txbLastMessage.Text = $"[{FindResource<string>("VideoTalk")}]";
                        break;
                    default:
                        break;
                }
                txbLastTime.Text = chatMessages.CreateTime.ToString("t");
            }
        }


        //鼠标点击切换聊天框
        private void BrdChat_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            brdChat.IsEnabled = false;//列表框禁用
            if (borderSelect != null)
            {
                borderSelect.IsEnabled = true;
            }
            borderSelect = brdChat;
            //把选择的聊天列表id传给选中朋友的id
            ChatFriendID = chatColumn.FriendID;
            TransferringData(typeof(ChatMain), DataPassingType.SelectMessage, this);
        }
        //未读消息
        private void BrdUnread_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (chatColumn.Unread > 0 && MasterChat.brdUnread.Visibility == Visibility.Collapsed)
            {
                ThreadPool.QueueUserWorkItem(ReadMessage);
            }
        }

        //发送事件
        public void Send()
        {
            //将方法排入队列以便执行。并指定包含该方法所用数据的对象,此方法在有线程池线程变得可用时执行。
            ThreadPool.QueueUserWorkItem(SendMessage);
        }

        //异步进程，发送消息
        private  void SendMessage(object data)
        {
            chatColumn.IsUsable = false;
            RichMessageModel richMessage = new RichMessageModel();//新建消息对象
            Dispatcher.Invoke(delegate
            {            
                foreach (Block item in chatColumn.Flow.Blocks)
                {
                    if (item is Paragraph paragraph)
                    {
                        foreach (Inline coll in paragraph.Inlines)
                    {
                        if (coll is Run run)
                        {
                            richMessage.RichMessageContents.Add(new RichMessageContentModel
                            {
                                MessageType = RichMessageType.Text,
                                Content = run.Text,
                                FileAttribute = null
                            });
                        }
                    }
                    }
                    List<RichMessageContentModel> richesText = richMessage.Filter(RichMessageType.Text);
                  
                    string message = string.Empty;
                    foreach (RichMessageContentModel iem in richesText)
                    {
                        message += iem.Content;
                    }
                    ChatMessagesModel e = new ChatMessagesModel() { ChatID = "2", MessageContent = message, SenderID = "0", ReceiverID = "4" };
                    chatColumn.ChatContent.Add(e);
                    scroll.ScrollToEnd();
                    
                }
            });
            Dispatcher.Invoke(delegate
            {
                chatColumn.IsUsable = true;
                chatColumn.Flow.Blocks.Clear();//清空文本框               
            });
        }

        //读取未读消息
        private void ReadMessage(object data)
        {
            lock (chatColumn.ChatContent)
            {
                if (chatColumn.ChatContent.LastOrDefault(item => item.SenderID != UserID && !item.IsRead) is ChatMessagesModel chatMessages)
                {
                    if (ChatService.ReadMessage(chatColumn.ChatID, chatMessages.ID))
                    {
                        foreach (ChatMessagesModel item in chatColumn.ChatContent.Where(item => item.ReceiverID == UserID && !item.IsRead && !item.IsWithdraw))
                        {
                            item.IsRead = true;
                        }
                        chatColumn.Unread = 0;
                    }
                }
            }
        }
    }
}
