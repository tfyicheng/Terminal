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

namespace Terminal.Component.Controls
{
    /// <summary>
    /// ContactsCfgView.xaml 的交互逻辑
    /// </summary>
    public partial class ContactsCfgView : UserControl
    {
        public ContactsCfgView()
        {
            InitializeComponent();
#if X686DPS
            comboBoxRemoteContactType.SelectedIndex = 0;
#else
            comboBoxRemoteContactType.SelectedIndex = 1;
#endif
        }
    }
}
