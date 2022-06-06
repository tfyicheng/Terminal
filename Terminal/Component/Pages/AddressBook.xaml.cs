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
using Terminal.Library.ResultModel;
using Terminal.Library.Service;
using Terminal.Library.ViewModel;

namespace Terminal.Component.Pages
{
    /// <summary>
    /// AddressBook.xaml 的交互逻辑
    /// </summary>
    public partial class AddressBook : Page
    {
        private readonly ContactPersonViewModel mainData;
        public AddressBook()
        {
            InitializeComponent();
            mainData = Resources["mainData"] as ContactPersonViewModel;
           // this.DataContext = mainData;    
        //    SignalRClientHelper.FriendChangedSignalR += SignalRClientHelper_FriendChangedSignalR;

        }

        //通讯录主体加载，获取数据
        private void AddressBookMain_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Load);
        }



        //通讯录获取数据
        private void Load(object data)
        {
            if (mainData.Friends == null)
            {
                if (UserManagerService.GetFriendList(out List<FriendSortModel> friendSorts))
                {
                    mainData.Friends = friendSorts;
                }
            }
            //if (mainData.NewFriends == null)
            //{
            //    if (UserManagerService.GetNewFriendList(out List<NewFriendBriefModel> newFriendBrief))
            //    {
            //        mainData.NewFriends = newFriendBrief;
            //    }
            //}
        }

        private void ItemsControl_ManipulationBoundaryFeedback(object sender, ManipulationBoundaryFeedbackEventArgs e)
        {
            e.Handled = true;
        }

        //private void SignalRClientHelper_FriendChangedSignalR(string sort, string friendID, bool state)
        //{
        //    if (UserManagerService.GetFriendList(out List<FriendSortModel> friendSorts))
        //    {
        //        mainData.Friends = friendSorts;
        //    }
        //    if (UserManagerService.GetNewFriendList(out List<NewFriendBriefModel> newFriendBrief))
        //    {
        //        mainData.NewFriends = newFriendBrief;
        //    }
        //}
    }
}
