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

            detailData = DataContext as InfoDetailsModel;
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
            //Dispatcher.Invoke(delegate
            //{
            //    txbRemarkNameAction.Text = "\xe78c";
            //    txbRemarkInformationAction.Text = "\xe78c";
            //});
            if (UserManagerService.GetFriendInfo(out InfoDetailsModel friendDetails, friendID: ClassHelper.ContactPersonFriendID))
            {
                if (ClassHelper.ContactPersonFriendID == friendDetails.UserID)
                {
                    detailData.UserID = friendDetails.UserID;
                    detailData.NickName = friendDetails.NickName;
                    //detailData.RemarkName = friendDetails.RemarkName;
                    //detailData.HeadPortrait = friendDetails.HeadPortrait;
                    //detailData.PhoneNumber = friendDetails.PhoneNumber;
                    detailData.Email = friendDetails.Email;
                    //detailData.Gender = friendDetails.Gender;
                    //detailData.Birthday = friendDetails.Birthday;
                    //detailData.Location = friendDetails.Location;
                    //detailData.Profession = friendDetails.Profession;
                    //detailData.Personalized = friendDetails.Personalized;
                    //detailData.RemarkInformation = friendDetails.RemarkInformation;
                    //detailData.OnLine = friendDetails.OnLine;
                    //detailData.Friend = friendDetails.Friend;
                  
                }
            }
        }

        private void BtnSendMessage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnVoiceCall_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtRemark_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TxbRemark_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
