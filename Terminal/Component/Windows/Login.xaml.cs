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
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        public readonly static Window config;
        public Login()
        {
            InitializeComponent();
         
          
        }

        //窗体拖拽
        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }




        //登陆
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            //string accountstr = account.Text.ToString();
            //IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(
            //    password.SecurePassword);
            //string passwordstr = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            //if ("123" == accountstr && "123" == passwordstr)
            //{
            //    //MessageBox.Show("登录成功！");
            //    MainWindow mainwindow = new MainWindow();
            //    mainwindow.Show();
            //    Close();

            //}
            //else
            //{
            //    MessageBox.Show("用户不存在或密码错误！");
            //}
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Close();
        }

        //接入配置
        private void SetConfig(object sender, RoutedEventArgs e)
        {
            Config con = new Config();
            con.Show();
        }

        //关闭
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
