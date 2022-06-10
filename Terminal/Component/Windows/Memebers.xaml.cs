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
using System.Windows.Shapes;
using Terminal.Library.ResultModel;
using Terminal.Library.Service;
using Terminal.Library.ViewModel;

namespace Terminal.Component.Windows
{
    /// <summary>
    /// Memebers.xaml 的交互逻辑
    /// </summary>
    public partial class Memebers : Window
    {
        //Point _pressedPosition;
        //bool _isDragMoved = false;


        private readonly ContactPersonViewModel friendData;
     ///  private readonly FriendSortModel friendData;
        public Memebers()
        {
            InitializeComponent();
            friendData = Resources["friendData"] as ContactPersonViewModel;
        }

        private void Window_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
                DragMove();
        }

        private void AddMain_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Load);
        }

        //获取通讯录数据
        private void Load(object data)
        {
            //if (friendData.FriendInfos == null)
            //{
            //    if (UserManagerService.GetFriendList(out List<FriendSortModel> friendSorts))
            //    {
            //        FriendSortModel addSorts = friendSorts.Find((FriendSortModel s) => s.Sort == "用户");
            //        //mainData.Friends = addSorts;
            //        friendData.FriendInfos = addSorts.FriendInfos;
    
                  
            //    }
            //}


            if (friendData.Friends == null)
            {
                if (UserManagerService.GetFriendList(out List<FriendSortModel> friendSorts))
                {
                    friendData.Friends = friendSorts;
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

        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            Meeting meeting = new Meeting();
            meeting.Show();
            this.Close();
        }


        //void Window_PreviewMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    //_pressedPosition = e.GetPosition(this);
        //   
        //}

        //void Window_PreviewMouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    if (Mouse.LeftButton == MouseButtonState.Pressed && _pressedPosition != e.GetPosition(this))
        //    {
        //        _isDragMoved = true;
        //        DragMove();
        //    }
        //}

        //void Window_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        //{
        //    if (_isDragMoved)
        //    {
        //        _isDragMoved = false;
        //        e.Handled = true;
        //    }
        //}



    }
}
