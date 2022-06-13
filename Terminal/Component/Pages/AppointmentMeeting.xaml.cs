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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Terminal.Component.Windows;
using Terminal.Library.ResultModel;
using Terminal.Library.Service;
using Terminal.Library.ViewModel;

namespace Terminal.Component.Pages
{
    /// <summary>
    /// AppointmentMeeting.xaml 的交互逻辑
    /// </summary>
    public partial class AppointmentMeeting : Page
    {
        private readonly MeetingModel mainData;
        public AppointmentMeeting()
        {
            InitializeComponent();
            mainData = Resources["mainData"] as MeetingModel;
        }

        //主体加载，获取数据
        private void Main_Loaded(object sender, RoutedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Load);
        }



        //会议列表获取数据
        private void Load(object data)
        {
            if (mainData.Meetings == null)
            {
                if (MeetingService.GetMeetingList(out List<MeetingSortModel> MeetingSorts))
                {
                    mainData.Meetings = MeetingSorts;
                }
            }
          
        }

        //添加成员
        private void AddMemebers(object sender, RoutedEventArgs e)
        {
            Memebers memebers = new Memebers();
            memebers.Show();
        }
    }
}
