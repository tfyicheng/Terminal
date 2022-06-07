using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Terminal.Common;
using Terminal.Library.ResultModel;
using Terminal.Library.Service;

namespace Terminal.Component.Controls
{
    /// <summary>
    /// InfoPage.xaml 的交互逻辑
    /// </summary>
    public partial class InfoPage : UserControl
    {

        private readonly InfoDetailsModel detailData;
        public InfoPage()
        {
            InitializeComponent();

            detailData = this.DataContext as InfoDetailsModel;
          //  detailData = Resources["InfoDetail"] as InfoDetailsModel;
            //this.DataContext = detailData;

        }


        private void UserControlMain_Loaded(object sender, RoutedEventArgs e)
        {
            ClassHelper.DataPassingChanged += ClassHelper_DataPassingChanged;

        }

        private void UserControlMain_Unloaded(object sender, RoutedEventArgs e)
        {
            ClassHelper.DataPassingChanged -= ClassHelper_DataPassingChanged;
        }

        //触发事件类型；选择朋友
        private void ClassHelper_DataPassingChanged(ClassHelper.DataPassingType dataType, object data)
        {
            if (dataType == ClassHelper.DataPassingType.SelectFriend)
            {
                ClassHelper.ContactPersonFriendID = data.ToString();
                ThreadPool.QueueUserWorkItem(GetFriendDetails, ClassHelper.ContactPersonFriendID);
                Dispatcher.Invoke(delegate
                {
                    Visibility = Visibility.Visible;
                });
            }
        }

        //获取朋友信息赋值给页面
        private void GetFriendDetails(object data)
        {
            Dispatcher.Invoke(delegate
            {
                txbRemarkNameAction.Text = "\xe78c";
                txbRemarkInformationAction.Text = "\xe78c";

            });
            if (UserManagerService.GetFriendInfo(out InfoDetailsModel friendDetails, friendID: ClassHelper.ContactPersonFriendID))
            {
                if (ClassHelper.ContactPersonFriendID == friendDetails.UserID)
                {
                    //Dispatcher.Invoke(delegate  绑定方案二：控件值直接绑定到输出参数上，需在另一个线程进行
                    //{
                    //    Nick.SetBinding(TextBlock.TextProperty, new Binding { Source = friendDetails, Path = new PropertyPath(nameof(friendDetails.NickName)) });
                    //});

                    //绑定方案一：输出参数赋值给上下文
                    detailData.UserID = friendDetails.UserID;
                    detailData.NickName = friendDetails.NickName;
                    //detailData.RemarkName = friendDetails.RemarkName;
                    //detailData.HeadPortrait = friendDetails.HeadPortrait;
                    detailData.PhoneNumber = friendDetails.PhoneNumber;
                   // detailData.Email = friendDetails.Email;
                    //detailData.Gender = friendDetails.Gender;
                    //detailData.Birthday = friendDetails.Birthday;
                    detailData.Location = friendDetails.Location;
                    //detailData.Profession = friendDetails.Profession;
                    //detailData.Personalized = friendDetails.Personalized;
                    //detailData.RemarkInformation = friendDetails.RemarkInformation;
                    //detailData.OnLine = friendDetails.OnLine;
                    //detailData.Friend = friendDetails.Friend;
                
                }
            }
        }
        //从通讯录跳转聊天
        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {
            //QueueUserWorkItem：将方法排入队列以便执行。 此方法在有线程池线程变得可用时执行。
            ThreadPool.QueueUserWorkItem(SendMessage);
        }

        //备注失去焦点事件
        private void TxtRemark_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        //备注点击事件
        private void TxbRemark_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice == null)
            {
                TxbRemark_PointerUp(sender);
            }
        }

        //备注更新触发
        private void TxbRemark_PointerUp(object sender)
        {
        
        }

       //执行通信，跳转聊天
       private void SendMessage(object data)
        {
            if (ChatService.AddChat(detailData.UserID))
            {
                ClassHelper.ChatFriendID = detailData.UserID;
                ClassHelper.SwitchRoute(ClassHelper.PageType.ManualTest);
            };
        }
    }
}
