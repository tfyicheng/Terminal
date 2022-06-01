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
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Hide();
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
