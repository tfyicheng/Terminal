using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Terminal.Library.Service;
using Terminal.Library.ViewModel;

namespace Terminal.Component.Pages
{
    /// <summary>
    /// ManualTest.xaml 的交互逻辑
    /// </summary>
    public partial class ManualTest : Page
    {
        private readonly ManualTestView mainData;
        public ManualTest()
        {
            InitializeComponent();
           
            mainData = DataContext as ManualTestView;
        }


        #region 窗体事件
        //窗体加载事件
        private void ManualTestMain_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Load);
        }

        //窗体卸载事件
        private void ManualTestMain_Unloaded(object sender, RoutedEventArgs e)
        {

        }


        #endregion

        #region 执行事件

  //页面加载时获取聊天列表数据
        private void Load(object data)
        {

           // 如果没有数据
            if (mainData.ChatColumnInfos.Count == 0)
            {
                //成功拿到聊天列表数据
                if (ChatService.GetChatColumnInfo(out List<ChatColumnInfoModel> chatColumnInfos))
                {
                    //同步派发一个委托类型的事件
                    Dispatcher.Invoke(delegate
                    {
                            //
                            foreach (ChatColumnInfoModel item in chatColumnInfos)
                        {
                            Dispatcher.Invoke(delegate
                            {
                                mainData.ChatColumnInfos.Add(item);
                            });
                        }
                    });
                }
            }

        }

        #endregion

      
    }
}
