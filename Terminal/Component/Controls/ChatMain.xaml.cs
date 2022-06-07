using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Terminal.Component.Windows;
using Terminal.Library.ViewModel;
using static Terminal.Common.ClassHelper;
using HandyControl;


namespace Terminal.Component.Controls
{
    /// <summary>
    /// ChatMain.xaml 的交互逻辑
    /// </summary>
    public partial class ChatMain : UserControl
    {
        readonly P2PCall p2pcall = new P2PCall();
        private readonly ChatMainViewModel chatMainData;//数据上下文
        private ChatItem chatItem;
        public ChatMain()
        {
            InitializeComponent();
            chatMainData = DataContext as ChatMainViewModel;
        }


        //聊天页面的主控件加载
        private void UserControlMain_Loaded(object sender, RoutedEventArgs e)
        {
            DataPassingChanged += ClassHelper_DataPassingChanged; //注册事件
        }


        //根据不同数据类型做不同事情
        private void ClassHelper_DataPassingChanged(DataPassingType dataType, object data)
        {
            if (dataType == DataPassingType.Paste)
            {
                rtbMessage.Paste(); //输入框内容粘贴
            }
            else if (dataType == DataPassingType.MessageFocus)
            {
                if (data.ToString() == chatMainData.ChatID)
                {
                    rtbMessage.Focus();//输入框获取焦点
                }
            }
            else if (dataType == DataPassingType.SelectMessage) //选择列表消息,切换聊天界面
            {
                chatItem = data as ChatItem;
                Visibility = Visibility.Visible;
                ChatColumnInfoModel chatColumnInfo = chatItem.DataContext as ChatColumnInfoModel;
                chatMainData.ChatID = chatColumnInfo.ChatID;
              txbFriendNickName.SetBinding(TextBlock.TextProperty, new Binding { Source = chatColumnInfo, Path = new PropertyPath(string.IsNullOrEmpty(chatColumnInfo.RemarkName) ? nameof(chatColumnInfo.NickName) : nameof(chatColumnInfo.RemarkName)) });
                rtbMessage.SetBinding(IsEnabledProperty, new Binding { Source = chatColumnInfo, Path = new PropertyPath(nameof(chatColumnInfo.IsUsable)) });
                btnSend.SetBinding(IsEnabledProperty, new Binding { Source = chatColumnInfo, Path = new PropertyPath(nameof(chatColumnInfo.IsUsable)) });
                if (chatColumnInfo.Flow == null)
                {
                    chatColumnInfo.Flow = new FlowDocument();
                    chatColumnInfo.Flow.Loaded += Flow_Loaded;
                }
                rtbMessage.Document = chatColumnInfo.Flow;
                brdChat.Child = chatItem.MasterChat;
            }
        }

        private void Flow_Loaded(object sender, RoutedEventArgs e)
        {
            rtbMessage.Selection.Select(rtbMessage.Document.ContentEnd, rtbMessage.Document.ContentEnd);
            rtbMessage.Focus();
        }

        //发送按钮
        private void BtnSend_Click(object sender, RoutedEventArgs e)
        {
            //调用列表控件的发送方法
            chatItem.Send();
        }

        private void RtbMessage_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void RtbMessage_Pasting(object sender, DataObjectPastingEventArgs e)
        {

        }
        //语音发送
        private void VoiceSend(object sender, MouseButtonEventArgs e)
        {
            VoiceSend voicoSend = new VoiceSend();
            voicoSend.Show();
        }
        //语音，视频通话
        private void P2PCall(object sender, MouseButtonEventArgs e)
        {          
             TextBlock border = (TextBlock)sender;
            SwitchCallRoute((CallType)Enum.Parse(typeof(CallType), $"{border.Name}"));
            p2pcall.Show();
          
        }

        //图片发送
        private void PicSend(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Title = "选择图片";
            openFileDialog.FileName = string.Empty;
            openFileDialog.Filter = "png文件|*.png|jpg文件|*.jpg|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "txt";
            System.Windows.Forms.DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                Console.WriteLine("用户取消");
                return;
             
            }
            string fileName = openFileDialog.FileName;
            Console.WriteLine(fileName);
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    return openFileDialog.FileName;
            //}
            //else
            //{
            //    return "";
            //}
        }

        //文件发送
        private void FileUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Title = "选择文件";
            openFileDialog.FileName = string.Empty;
           // openFileDialog.Filter = "png文件|*.png|jpg文件|*.jpg|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "txt";
            System.Windows.Forms.DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                Console.WriteLine("用户取消");
                return;
            }
            string fileName = openFileDialog.FileName;
            Console.WriteLine(fileName);
        }

        //视频发送
        private void VideoSend(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            openFileDialog.Title = "选择视频";
            openFileDialog.FileName = string.Empty;
            openFileDialog.Filter = "mp4文件|*.mp4|rmvb文件|*.rmvb|所有文件|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "txt";
            System.Windows.Forms.DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                Console.WriteLine("用户取消");
                return;
            }
            string fileName = openFileDialog.FileName;
            Console.WriteLine(fileName);
        }

        private void MeetingTalk(object sender, MouseButtonEventArgs e)
        {
            HandyControl.Controls.Growl.Success("666");
        }
    }
}
