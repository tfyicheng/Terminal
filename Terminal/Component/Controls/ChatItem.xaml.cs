using System;
using System.Collections.Generic;
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
            txbNickName.SetBinding(Run.TextProperty, "NickName");
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


        private void Scroll_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            if (scroll.VerticalOffset > scroll.ScrollableHeight - 50)
            {
                MasterChat.brdUnread.Visibility = Visibility.Collapsed;
            }
        }

        //读取消息
        private void ReadMessage(object data)
        {
            lock (chatColumn.ChatContent)
            {
                //if (chatColumn.ChatContent.LastOrDefault(item => item.SenderID != UserID && !item.IsRead) is ChatMessagesModel chatMessages)
                //{
                //    if (ChatService.ReadMessage(chatColumn.ChatID, chatMessages.ID))
                //    {
                //        foreach (ChatMessagesModel item in chatColumn.ChatContent.Where(item => item.ReceiverID == UserID && !item.IsRead && !item.IsWithdraw))
                //        {
                //            item.IsRead = true;
                //        }

                //        chatColumn.Unread = 0;
                //    }
                //}
            }
        }

        //当此元素的数据上下文更改时发生
        private void UserControlMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is ChatColumnInfoModel chatColumnInfo)
            {
                chatColumn = chatColumnInfo;
            }
        }

        //鼠标点击切换聊天框
        private void BrdChat_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

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
         

        }
    }
}
