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
using System.Windows.Shapes;
using Terminal.Common;

namespace Terminal.Component.Windows
{
    /// <summary>
    /// P2PCall.xaml 的交互逻辑
    /// </summary>
    public partial class P2PCall : Window
    {
        public P2PCall()
        {
            InitializeComponent();
            
        }


        //窗体状态事件
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void BtnState_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void P2PCall_Loaded(object sender, RoutedEventArgs e)
        {
            this.CallRouteMain.Navigate(ClassHelper.voiceTalk);
        }
    }
}
