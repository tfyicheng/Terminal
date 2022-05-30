using System;
using System.Collections.Generic;
using System.Data;
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

namespace Terminal.Component.Pages
{
    /// <summary>
    /// AutoTest.xaml 的交互逻辑
    /// </summary>
    public partial class AutoTest : Page
    {
        public AutoTest()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "任务一", Status= 1, StartTime = new DateTime(1971, 7, 23), EndTime = new DateTime(1971, 7, 23),Belong = "接入网1",Type = "语音",Received = "单位一"});
            users.Add(new User() { Id = 2, Name = "任务二", Status= 2, StartTime = new DateTime(1971, 7, 23), EndTime = new DateTime(1971, 7, 23),Belong = "接入网1",Type = "语音",Received = "单位一"});
            users.Add(new User() { Id = 3, Name = "任务三", Status = 1, StartTime = new DateTime(1971, 7, 23), EndTime = new DateTime(1971, 7, 23), Belong = "接入网1", Type = "语音", Received = "单位一" });


            dg.ItemsSource = users;
        }
        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime StartTime { get; set; }

            public int Status { get; set; }

            public string Belong { get; set; }
            public DateTime EndTime { get; set; }
            public string Type { get; set; }    
            public string Received { get; set; }    
        }

        private void AutoTest_Loaded(object sender, RoutedEventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("ceshi", typeof(string));
            //dt.Columns.Add("ceshi2", typeof(string));
            //dt.Columns.Add("ceshi3", typeof(string));
            //dt.Rows.Add("3","555","9");
            //dt.Rows.Add("3", "55d5", "9");
            //dg.ItemsSource = dt.DefaultView;
        }
    }
}
