using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;
using Terminal.Library.ResultModel;

namespace Terminal.Library.ViewModel
{
   public class MeetingModel : ModelBase
    {
        private List<MeetingSortModel> meetings;


        public List<MeetingSortModel> Meetings
        {
            get => meetings;
            set
            {
                meetings = value;
                OnPropertyChanged(nameof(Meetings));
            }
        }

        public override void InitializeVariable()
        {
            meetings = null;
          //  throw new NotImplementedException();
        }
    }

  

 
}
