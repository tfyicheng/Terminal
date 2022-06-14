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
        private int talks=2;
        public Meeting()
        {
            InitializeComponent();
           List<toItc> list = new List<toItc>();
            for (int i = 0; i < talks; i++)
            {
                list.Add(new toItc() { color = "pink",title= i });
            }
            //list.Add(new toItc() { color = "red" });
            //list.Add(new toItc() { color = "pink" });
            itc.ItemsSource = list;

            setWH();
          
            
        }

        public void setBwh()
        {
          //  Border itcb = this.FindName("itcb") as Border;
            // var itcb = (Border)FindName(string.Format("itcb", i));
            //switch (talks)
            //{

            //    case 2:
            //        itcb.Width = SystemParameters.PrimaryScreenWidth;
            //        itcb.Height = SystemParameters.PrimaryScreenWidth;
            //        break;
            //    case 3:
            //    case 4:
            //        this.Width = 860;
            //        this.Height = 1030;
            //        break;
            //    case 5:
            //    case 6:
            //        this.Width = 1290;
            //        this.Height = 1030;
            //        break;
            //    case 7:
            //    case 8:
            //        this.Width = 1720;
            //        this.Height = 1030;
            //        break;
            //    default:
            //        break;
            //}
            Console.WriteLine("test");
        }

        public void setWH()
        {
       
          
            switch (talks)
            {

                case 2:
                    this.Width = 860;
                    this.Height = 510;
                   
                    break;
                case 3:
                case 4:
                    this.Width = 860;
                    this.Height = 1030;
                    break ;                 
                case 5:
                case 6:
                    this.Width = 1290;
                    this.Height = 1030;
                    break;
                case 7:
                case 8:
                    this.Width = 1720;
                    this.Height = 1030;
                    break;
                default:
                    break;
            }
        }

        public class toItc
        {
            public string color { get; set; }
            public int title { get; set; }  
        }

        //窗体状态事件
        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void BtnState_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
            setBwh();
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
        //关闭声音
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
