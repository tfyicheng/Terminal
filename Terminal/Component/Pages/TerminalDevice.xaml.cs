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

namespace Terminal.Component.Pages
{
    /// <summary>
    /// TerminalDevice.xaml 的交互逻辑
    /// </summary>
    public partial class TerminalDevice : Page
    {
        public TerminalDevice()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", Status = 1, StartTime = new DateTime(1971, 7, 23), EndTime = new DateTime(1971, 7, 23),Type = "语音",From = "单位一",Way="发起" });
            users.Add(new User() { Id = 1, Name = "John Doe", Status = 1, StartTime = new DateTime(1971, 7, 23), EndTime = new DateTime(1971, 7, 23),Type = "语音",From = "单位一",Way="发起" });


            this.DataContext = users;
        }

        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime StartTime { get; set; }

            public int Status { get; set; }

            public string Way { get; set; }
            public DateTime EndTime { get; set; }
            public string Type { get; set; }
            public string From { get; set; }
        }
    }
}
