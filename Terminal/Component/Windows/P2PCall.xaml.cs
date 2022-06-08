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
using static Terminal.Common.ClassHelper;

namespace Terminal.Component.Windows
{

    /// <summary>
    /// P2PCall.xaml 的交互逻辑
    /// </summary>


    public partial class P2PCall : Window
    {
        public static bool CallStatus;
    
        private void ClassHelper_RoutedChanged(CallType typeName)
        {
            //线程调用
            Dispatcher.Invoke(delegate
            {
                switch (typeName)
                {
                    case CallType.VoiceTalk:
                       CallRouteMain.Navigate(ClassHelper.voiceTalk);
                        break;
                    case CallType.VideoTalk:
                        CallRouteMain.Navigate(ClassHelper.videoTalk);                     
                        break;
                    case CallType.IPCall:
                        CallRouteMain.Navigate(ClassHelper.ipCall);
                        break;
                    default:                     
                        break;
                }
            });
        }

        public P2PCall()
        {
            InitializeComponent();
            ClassHelper.CallRouted += ClassHelper_RoutedChanged;//注册委托

        }



        //窗体状态事件
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void BtnState_Click(object sender, RoutedEventArgs e)
        {
            double x1 = SystemParameters.PrimaryScreenWidth;//得到屏幕整体宽度
            double y1 = SystemParameters.PrimaryScreenHeight;//得到屏幕整体高度
            Thickness margin = new Thickness(0, 0, 0, 0);
            Thickness margin2 = new Thickness(0, 5, 5, 0);
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
            if(WindowState == WindowState.Maximized)
            {
                this.p2pMain.Height = y1;
                this.p2pMain.Width = x1;
                p2pWin.Margin = margin;
            }
            else
            {
                this.p2pMain.Height = 600;
                this.p2pMain.Width = 360;
                p2pWin.Margin = margin2;
            }
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            CallStatus = false;
        }
        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        public void P2PCall_Loaded(object sender, RoutedEventArgs e)
        {            
        }
    
    }
}
