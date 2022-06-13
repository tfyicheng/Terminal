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
    /// MeetingHistoryItem.xaml 的交互逻辑
    /// </summary>
    public partial class MeetingHistoryItem : UserControl
    {
        public MeetingHistoryItem()
        {
            InitializeComponent();
        }

        private void UserControlMain_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is MeetingSortModel info)
            {
                txbSort.Text = info.Sort;
                itcInfos.ItemsSource = info.MeetingInfos;
            }
        }
    }
}
