using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Terminal.Library;

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


        private void LoginMain_Loaded(object sender, RoutedEventArgs e)
        {
            ClassHelper.MessageHint += ClassHelper_MessageHint;
        }

            private void LoginMain_Unloaded(object sender, RoutedEventArgs e)
        {
            ClassHelper.MessageHint -= ClassHelper_MessageHint;
        }

        //信息提示
        private void ClassHelper_MessageHint(int messageType, string message)
        {
            Dispatcher.Invoke(delegate
            {
                ClassHelper.AlertMessageBox(this, ClassHelper.MessageBoxType.Inform, message);
            });
        }

        //窗体拖拽
        private void Window_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }




        //登陆触发
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



            //使用一个InPtr类型值来存储加密字符串的起始点
           IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(Password.SecurePassword);

            //使用.net内部算法把IntPtr指向处的字符集合转换成字符串
            string password = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            if (string.IsNullOrEmpty(LoginName.Text))
            {
                LoginName.Focus();
                 ClassHelper.MessageAlert(null, 3, "请输入账号");
                //MessageBoxButtonModel rightButton = new MessageBoxButtonModel()
                //{
                //    Action = new Action(() =>
                //    {
                //        执行操作
                //    })
                //};
                //ClassHelper.AlertMessageBox(this, ClassHelper.MessageBoxType.Select, ClassHelper.FindResource<string>("Hint"), rightButton: rightButton);
            }
            else if (string.IsNullOrEmpty(password))
            {
               Password.Focus();
                ClassHelper.MessageAlert(null, 3, "请输入密码");

            }
            else
            {
                ThreadPool.QueueUserWorkItem(LoginRequest);
            }

           
        }

        //登陆处理
        private void LoginRequest(object data)
        {

            Dispatcher.Invoke(delegate
            {
                LoginName.IsEnabled = false;
                Password.IsEnabled = false;
                Loginbtn.IsEnabled = false;
            });
            Password.Clear();
            Dispatcher.Invoke(delegate
            {

                MainWindow mainwindow = new MainWindow();
                mainwindow.Show();
                Close();
            });
          
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
