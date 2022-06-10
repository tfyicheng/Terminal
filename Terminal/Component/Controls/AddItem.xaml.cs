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
using Terminal.Library.ResultModel;

namespace Terminal.Component.Controls
{
    /// <summary>
    /// AddItem.xaml 的交互逻辑
    /// </summary>
    public partial class AddItem : UserControl
    {
        public AddItem()
        {
            InitializeComponent();
            
        }

        private void UserControlMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

            if (DataContext is FriendSortModel friend)
            {
                // itcFriendInfos.ItemsSource = friend.FriendInfos;
                if (friend.Sort == "用户")
                {
                    itcFriendInfos.ItemsSource = friend.FriendInfos;
                }
            }
        }

        private void BrdChat_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void BrdDetail_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BrdDetail_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
