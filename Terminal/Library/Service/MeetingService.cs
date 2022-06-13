using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Library.ResultModel;

namespace Terminal.Library.Service
{
    public class MeetingService
    {
        //获取朋友列表
        public static bool GetMeetingList(out List<MeetingSortModel> meetingSorts)
        {

            if (true)
            {
                meetingSorts = new List<MeetingSortModel>();
                List<MeetingInfoModel> lista = new List<MeetingInfoModel>();
                List<MeetingInfoModel> listb = new List<MeetingInfoModel>();

                MeetingInfoModel aa = new MeetingInfoModel() { Theme="xx研讨会", Date="12:00 - 13:00",MeetingId="0895455",Originator="测试用户一" };
                MeetingInfoModel bb = new MeetingInfoModel() { Theme = "xx会", Date = "12:00 - 13:00", MeetingId = "1895455", Originator = "用户一" };
                MeetingInfoModel a1 = new MeetingInfoModel() { Theme = "研讨会", Date = "12:00 - 13:00", MeetingId = "3895455", Originator = "测试用户四" };
                MeetingInfoModel b2 = new MeetingInfoModel() { Theme = "视频会议", Date = "12:00 - 13:00", MeetingId = "4895455", Originator = "TestUser" };
                MeetingInfoModel b3 = new MeetingInfoModel() { Theme = "预定决策预定决策预定决策预定决策预定决策预定决策预定决策", Date = "12:00 - 13:00", MeetingId = "6895455", Originator = "测试用户一用户一用户一用户一用户一用户一用户一" };
             
                lista.Add(aa);
                lista.Add(bb); lista.Add(a1); 
                listb.Add(b2);
                listb.Add(b3);
                MeetingSortModel a = new MeetingSortModel() { Sort = "6月13日" };
                a.MeetingInfos = lista;
                MeetingSortModel b = new MeetingSortModel() { Sort = "6月14日" };
                b.MeetingInfos = listb;
                meetingSorts.Add(b);
                meetingSorts.Add(a);

                return true;
            }


        }
    }
}
