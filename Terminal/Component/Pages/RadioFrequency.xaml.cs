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
    /// RadioFrequency.xaml 的交互逻辑
    /// </summary>
    public partial class RadioFrequency : Page
    {
        public RadioFrequency()
        {
            InitializeComponent();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "John Doe", DevStatus = 1, Birthday = new DateTime(1971, 7, 23) });
            users.Add(new User() { Id = 1, Name = "John Doe", DevStatus = 2, Birthday = new DateTime(1971, 7, 23) });

            this.DataContext = users;
        }
        public class User
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public DateTime Birthday { get; set; }

            public int DevStatus { get; set; }
        }
    }
}
