using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;

namespace Terminal.Library.ResultModel
{
    public class MeetingInfoModel : ModelBase
    {
        private string date;
        private string theme;
        private string meetingId;
        private string originator;


        // 时间
        public string Date
        {
            get => date;
            set
            {
                date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        // 主题
        public string Theme
        {
            get => theme;
            set
            {
                theme = value;
                OnPropertyChanged(nameof(Theme));
            }
        }
        // 会议id
        public string MeetingId
        {
            get => meetingId;
            set
            {
                meetingId = value;
                OnPropertyChanged(nameof(MeetingId));
            }
        }

        //发起人
        public string Originator
        {
            get => originator;
            set
            {
                originator = value;
                OnPropertyChanged(nameof(Originator));
            }
        }

        public override void InitializeVariable()
        {
            date = string.Empty;
            theme = string.Empty;   
            theme = string.Empty;
            originator = string.Empty;
        //    throw new NotImplementedException();
        }
    }
}
