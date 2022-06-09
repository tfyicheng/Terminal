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
using Terminal.Component.Windows;
using Terminal.Common;
namespace Terminal
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassHelper.RoutedChanged += ClassHelper_RoutedChanged;//路由初始化
        }


        #region 窗体事件

       
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

        //窗体状态改变 (不设置这个事件最大化后关闭按钮会偏移)
        private void AppMain_StateChanged(object sender, EventArgs e)
        {
            // 为什么设置间距设置为4: https://www.cnblogs.com/dino623/p/uielements_of_window.html
            if (WindowState == WindowState.Maximized)
            {
                Thickness thickness = SystemParameters.WindowResizeBorderThickness;
                Main.Margin = new Thickness(thickness.Left + 4, thickness.Top + 4, thickness.Right + 4, thickness.Bottom + 4);
            }
            else
            {
                Main.Margin = new Thickness(0);
            }
        }

        #endregion

        #region 页面切换

        //路由事件
        private void BrdSelectPage_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (e.StylusDevice == null)
            {
                BrdSelectPage_PointerUp(sender);
            }
        }
        private static void BrdSelectPage_PointerUp(object sender)
        {

            Border border = (Border)sender;
            ClassHelper.SwitchRoute((ClassHelper.PageType)Enum.Parse(typeof(ClassHelper.PageType), border.Name));

        }
        //路由跳转后-样式处理
        private void FemRouteMain_Navigated(object sender, NavigationEventArgs e)
        {
            Grid grid = null;
            if (femRouteMain.CanGoBack)
            {
                //_ = femRouteMain.RemoveBackEntry();
                JournalEntry entry = this.femRouteMain.RemoveBackEntry();
            }
            switch ((ClassHelper.PageType)Enum.Parse(typeof(ClassHelper.PageType), e.Content.GetType().Name))
            {
                case ClassHelper.PageType.AutoTest:
                    //按钮样式相关
                    AutoTest.Tag = "1";
                    ManualTest.Tag = "0";
                    AddressBook.Tag = "0";
                    DataCollect.Tag = "0";
                    EnergyAssess.Tag = "0";
                    Main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FAFAFA"));
                    grid = AutoTest.Child as Grid;
                    break;
                case ClassHelper.PageType.ManualTest:
                    ManualTest.Tag = "1";
                    AutoTest.Tag = "0";
                    AddressBook.Tag = "0";
                    DataCollect.Tag = "0";
                    EnergyAssess.Tag = "0";
                    Main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                    grid = ManualTest.Child as Grid;
                    break;
                case ClassHelper.PageType.AddressBook:
                    AddressBook.Tag = "1";
                    ManualTest.Tag = "0";
                    AutoTest.Tag = "0";
                    DataCollect.Tag = "0";
                    EnergyAssess.Tag = "0";
                    Main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000"));
                    grid = AddressBook.Child as Grid;
                    break;
                case ClassHelper.PageType.DataCollect:
                    DataCollect.Tag = "1";
                    ManualTest.Tag = "0";
                    AutoTest.Tag = "0";
                    AddressBook.Tag = "0";
                    EnergyAssess.Tag = "0";
                    Main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000"));
                    grid = DataCollect.Child as Grid;
                    break;
                case ClassHelper.PageType.EnergyAssess:
                    EnergyAssess.Tag = "1";
                    ManualTest.Tag = "0";
                    AutoTest.Tag = "0";
                    DataCollect.Tag = "0";
                    AddressBook.Tag = "0";
                    Main.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000"));
                    grid = EnergyAssess.Child as Grid;
                    break;
                default:
                    break;
            }
        }

        //路由跳转导航
        private void ClassHelper_RoutedChanged(ClassHelper.PageType pageName)
        {
            Dispatcher.Invoke(delegate
            {
                if (femRouteMain.Content != null && femRouteMain.Content.GetType().Name == pageName.ToString())
                {
                    return;
                }
                switch (pageName)
                {
                    case ClassHelper.PageType.AutoTest:
                        femRouteMain.Navigate(ClassHelper.autoTest);
                        break;
                    case ClassHelper.PageType.ManualTest:
                        femRouteMain.Navigate(ClassHelper.manualTest);
                        break;
                    case ClassHelper.PageType.AddressBook:
                        femRouteMain.Navigate(ClassHelper.addressBook);
                        break;
                    case ClassHelper.PageType.DataCollect:
                        femRouteMain.Navigate(ClassHelper.dataCollect);
                        break;
                    case ClassHelper.PageType.EnergyAssess:
                        femRouteMain.Navigate(ClassHelper.energyAssess);
                        break;
                    default:
                        ClassHelper.MessageAlert(GetType(), 3, ClassHelper.FindResource<string>("PageDoesNotExist"));
                        break;
                }
            });
        }



        #endregion

        #region 执行事件

        //主窗体加载事件
        private void AppMain_Loaded(object sender, RoutedEventArgs e)
        {
            //把导航的事件放到线程池里
            System.Threading.ThreadPool.QueueUserWorkItem(Load);
        }

        //窗体加载先导航到自动测试
        private void Load(object data)
        {
            ClassHelper.SwitchRoute(ClassHelper.PageType.ManualTest);
        }



        //打开配置
        private void ConfigShow(object sender, RoutedEventArgs e)
        {
            //Login.config.Show();
        }


        //注销事件
        private void LoginOut(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }



        #endregion

        Point _pressedPosition;
        bool _isDragMoved = false;

        private void MeumDown(object sender, MouseButtonEventArgs e)
        {
            _pressedPosition = e.GetPosition(this);
        }

        private void MeumMove(object sender, MouseEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed && _pressedPosition != e.GetPosition(this))
            {
                _isDragMoved = true;
                DragMove();
            }
        }

        private void MeumUp(object sender, MouseButtonEventArgs e)
        {
            if (_isDragMoved)
            {
                _isDragMoved = false;
                e.Handled = true;
            }
        }
    }
}
