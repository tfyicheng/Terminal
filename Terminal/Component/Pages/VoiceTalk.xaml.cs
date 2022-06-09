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
using System.Globalization;

namespace Terminal.Component.Pages
{
    /// <summary>
    /// VoiceTalk.xaml 的交互逻辑
    /// </summary>
    public partial class VoiceTalk : Page
    {
        private bool jyStatue = false;
        private int voiceCallStatus = 0;
        public VoiceTalk()
        {
            InitializeComponent();
        }

        private void toJy(object sender, RoutedEventArgs e)
        {
            if(jyStatue == false)
            {
             this.jytb.Text = "取消静音";
                this.jybt.FontSize = 18;
                this.jybt.Content = "\ue6a4";
            jyStatue = true;
            }
            else
            {
                this.jytb.Text ="静音";
                this.jybt.FontSize = 25;
                this.jybt.Content = "\ue641";
                jyStatue = false;
            }
        }

    
       



    }
}
