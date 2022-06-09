using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;
using Terminal.Library.ResultModel;

namespace Terminal.Library.Service
{
    public class UserManagerService
    {
        //获取朋友列表
        public static bool GetFriendList(out List<FriendSortModel> friendSorts)
        {
         
            if (true)
            {
                friendSorts = new List<FriendSortModel>();
                List<FriendInfoModel> lista = new List<FriendInfoModel>();
                List<FriendInfoModel> listb = new List<FriendInfoModel>();

                FriendInfoModel aa = new FriendInfoModel() { NickName = "测试一", RemarkName = "888", UserID= "3", };
                FriendInfoModel bb = new FriendInfoModel() { NickName = "测试二", RemarkName = "888", UserID = "4" };
                FriendInfoModel cc = new FriendInfoModel() { NickName = "测试测试", RemarkName = "888", UserID = "5" };
                FriendInfoModel dd = new FriendInfoModel() { NickName = "测试33", RemarkName = "888", UserID = "6" };
                lista.Add(aa);
                lista.Add(bb);
                listb.Add(cc);
                listb.Add(dd);
                FriendSortModel a = new FriendSortModel() { Sort = "用户" };
                a.FriendInfos = lista;
                FriendSortModel b = new FriendSortModel() { Sort = "群组" };
             //   b.FriendInfos = listb;
               // friendSorts.Add(b);
                friendSorts.Add(a);
              
                return true;
            }

           
        }


        //获取朋友信息
        public static bool GetFriendInfo(out InfoDetailsModel friendDetails, string friendID = "", string phoneNumber = "")
        {
         
                if (friendID == "3")
                {
                    InfoDetailsModel a = new InfoDetailsModel() { NickName="测试一",Email="6666",UserID="3",PhoneNumber="100000",Location ="北京市"};
                    friendDetails = a;
                    return true;
                }
                else
                {
                    InfoDetailsModel b = new InfoDetailsModel() { NickName = "测试二", Email = "77777",UserID="4", PhoneNumber = "200000", Location = "广州市" };
                    friendDetails = b;
                    return true;
                }
            
          
        }

    }
}
