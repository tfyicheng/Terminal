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
        private int bl;
        List<toItc> list = new List<toItc>();
        public Meeting()
        {
            InitializeComponent();
            setWH();
            for (int i = 0; i < talks; i++)
            {

                list.Add(new toItc() { color = "pink", title = i, lenght = bl });
            }

            itc.ItemsSource = list;
          //  can.Width = SystemParameters.PrimaryScreenWidth;
           // can.Height = SystemParameters.PrimaryScreenHeight;

          

        }


        public void setWH()
        {
            switch (talks)
            {

                case 2:
                    this.Width = 860;
                    this.Height = 510;
                    bl = 430;
                    break;
                case 3:
                case 4:
                    this.Width = 860;
                    this.Height = 1030;
                    bl= 430;  
                    break ;                 
                case 5:
                case 6:
                    this.Width = 1290;
                    this.Height = 1030;
                    bl = 430;
                    break;
                case 7:
                case 8:
                    this.Width = 1720;
                    this.Height = 1030;
                    bl = 430;
                    break;
                case 9:
                case 10:
                    this.Width = SystemParameters.PrimaryScreenWidth;
                    this.Height = SystemParameters.PrimaryScreenHeight - 100;
                    bl = (int)SystemParameters.PrimaryScreenWidth/5;
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    this.Width = SystemParameters.PrimaryScreenWidth;
                    this.Height = SystemParameters.PrimaryScreenHeight-100;
                    bl = 270;
                    break;
                default:
                    this.Width = SystemParameters.PrimaryScreenWidth;
                    this.Height = SystemParameters.PrimaryScreenHeight - 100;
                    bl = 200;
                    break;
            }
        }

        public List<T> GetChildObjects<T>(DependencyObject obj, string name) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();
            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);
                if (child is T && (((T)child).Name == name || string.IsNullOrEmpty(name)))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, ""));//指定集合的元素添加到List队尾
            }
            return childList;
        }

        public class toItc
        {
            public string color { get; set; }
            public int title { get; set; }  
            public int lenght { get; set; }   
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
