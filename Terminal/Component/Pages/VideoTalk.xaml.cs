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

namespace Terminal.Component.Pages
{
    /// <summary>
    /// VideoTalk.xaml 的交互逻辑
    /// </summary>
    public partial class VideoTalk : Page
    {
        private bool cameraStatus = false;
        public VideoTalk()
        {
            InitializeComponent();
        }

        //跳转到语音通话
        private void toVoice(object sender, RoutedEventArgs e)
        {
            ClassHelper.SwitchCallRoute(ClassHelper.CallType.VoiceTalk);
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
    }
}
