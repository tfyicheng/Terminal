using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Library.ResultModel;

namespace Terminal.Library.Service
{
    public class UserManagerService
    {
        //获取朋友列表
        public static bool GetFriendList(out List<FriendSortModel> friendSorts)
        {
            friendSorts = null;
            if (true)
            {
                FriendInfoModel aa = new FriendInfoModel() { NickName = "123", RemarkName = "888" };

                FriendSortModel a = new FriendSortModel() { Sort="用户"};
                a.FriendInfos.Add(aa);
                friendSorts.Add(a);
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


    }
}
