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
           // friendSorts = null;
            if (true)
            {
                friendSorts = new List<FriendSortModel>();
                List<FriendInfoModel> lista = new List<FriendInfoModel>();

                FriendInfoModel aa = new FriendInfoModel() { NickName = "123", RemarkName = "888", UserID= "3" };
                FriendInfoModel bb = new FriendInfoModel() { NickName = "3456", RemarkName = "888", UserID = "4" };
                lista.Add(aa);
                lista.Add(bb);
                FriendSortModel a = new FriendSortModel() { Sort = "用户" };
                a.FriendInfos = lista;
                FriendSortModel b = new FriendSortModel() { Sort = "群组" };
             //   b.FriendInfos = lista;
               
                friendSorts.Add(a);
              //  friendSorts.Add(b);
                return true;
            }

            
            //if (ClassHelper.ServerRequest($"{ClassHelper.servicePath}/api/UserManager/GetFriendList", HttpMethod.Get, out JObject responseObj))
            //{
            //    friendSorts = JsonConvert.DeserializeObject<List<FriendSortModel>>(responseObj["Data"].ToString());
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


        //获取朋友信息
        public static bool GetFriendInfo(out InfoDetailsModel friendDetails, string friendID = "", string phoneNumber = "")
        {
           // friendDetails = null;
            friendDetails = new InfoDetailsModel();
            //if (ClassHelper.ServerRequest($"{ClassHelper.servicePath}/api/UserManager/GetFriendInfo?{(!string.IsNullOrEmpty(friendID) ? $"friendID={friendID}" : $"phoneNumber={phoneNumber}")}", HttpMethod.Get, out JObject responseObj))
            //{
            //    friendDetails = JsonConvert.DeserializeObject<FriendDetailsModel>(responseObj["Data"].ToString());
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
         
                if (friendID == "3")
                {
                    InfoDetailsModel a = new InfoDetailsModel() { NickName="666",Email="6666",UserID="3"};
                    friendDetails = a;
                    return true;
                }
                else
                {
                    InfoDetailsModel b = new InfoDetailsModel() { NickName = "777", Email = "77777",UserID="4" };
                    friendDetails = b;
                    return true;
                }
            
          
        }

    }
}
