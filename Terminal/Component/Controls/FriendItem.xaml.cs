using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Terminal.Component.Controls
{
    /// <summary>
    /// FriendItem.xaml 的交互逻辑
    /// </summary>
    public partial class FriendItem : UserControl
    {
        private static Border borderSelect;
     
        public FriendItem()
        {
            InitializeComponent();
          
        }

        private void UserControlMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is FriendSortModel friend)
            {
                txbSort.Text = friend.Sort;
                itcFriendInfos.ItemsSource = friend.FriendInfos;
            }
        }
        //列表的模板加载
        private void BrdDetail_Loaded(object sender, RoutedEventArgs e)
        {
            Border border = sender as Border;
            if ((border.Tag as FriendInfoModel).UserID == ClassHelper.ContactPersonFriendID)
            {
                border.IsEnabled = false;
                borderSelect = border;
            }
        }
        //切换好友详情触发
        private void BrdDetail_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice == null)
            {
                BrdDetail_PointerUp(sender);
            }
        }

        private static void BrdDetail_PointerUp(object sender)
        {
            Border border = sender as Border;
            border.IsEnabled = false;
            if (borderSelect != null)
            {
                borderSelect.IsEnabled = true;
            }
            borderSelect = border;           
            ClassHelper.TransferringData(typeof(InfoPage), ClassHelper.DataPassingType.SelectFriend, (border.Tag as FriendInfoModel).UserID);
        }
    }
}
