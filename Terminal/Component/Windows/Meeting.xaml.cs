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

namespace Terminal.Component.Windows
{
    /// <summary>
    /// Meeting.xaml 的交互逻辑
    /// </summary>
    public partial class Meeting : Window
    {

        private bool cameraStatus = false;
        private bool jyStatue = false;
        public Meeting()
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



        //关闭摄像头
        private void CloseCarmera(object sender, RoutedEventArgs e)
        {
            if (cameraStatus == false)
            {
                this.cameraT.Text = "关闭摄像头";
                this.cameraB.FontSize = 18;
                this.cameraB.Content = "\ue61e";
                cameraStatus = true;
            }
            else
            {
                this.cameraT.Text = "打开摄像头";
                this.cameraB.FontSize = 24;
                this.cameraB.Content = "\ue605";
                cameraStatus = false;
            }
        }

        private void CloseVoice(object sender, RoutedEventArgs e)
        {
            if (jyStatue == false)
            {
                this.jytb.Text = "取消静音";
                this.jybt.FontSize = 18;
                this.jybt.Content = "\ue6a4";
                jyStatue = true;
            }
            else
            {
                this.jytb.Text = "静音";
                this.jybt.FontSize = 25;
                this.jybt.Content = "\ue641";
                jyStatue = false;
            }
        }
    }
}
