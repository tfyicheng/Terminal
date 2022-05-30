using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;

namespace Terminal.Library.ViewModel
{
    class ManualTestView:ModelBase
    {
        public ObservableCollection<ChatColumnInfoModel> ChatColumnInfos { get; set; }
        public override void InitializeVariable()
        {


            ChatColumnInfos = new ObservableCollection<ChatColumnInfoModel>();
        }
    }
}
