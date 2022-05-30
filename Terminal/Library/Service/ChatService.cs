using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;
using Terminal.Library.ViewModel;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Terminal.Library.ResultModel;

namespace Terminal.Library.Service
{
    public static class ChatService
    {
    

        private static String res = "";

        private static String resp = "";


        //获取聊天列表数据


        public static bool GetChatColumnInfo(out List<ChatColumnInfoModel> chatColumnInfos)
    {
        chatColumnInfos = null;
        if (true)
        {
            chatColumnInfos = JsonConvert.DeserializeObject<List<ChatColumnInfoModel>>(res);
            return true;
        }
  
    }

    //根据id获取聊天信息
    public static bool GetChattingRecords(string chatID, out List<ChatMessagesModel> chatMessages)
    {
        chatMessages = null;
        if (true)
        {
            chatMessages = JsonConvert.DeserializeObject<List<ChatMessagesModel>>(resp);
            return true;
        }
    
    }

    public static bool SendMessage(string chatID, MessageType messageType, string messageContent)
        {
            JObject requestObj = new JObject()
            {
                { "ChatID", chatID },
                { "MessageType", messageType.ToString() },
                { "MessageContent", messageContent }
            };
            //return ClassHelper.ServerRequest($"{ClassHelper.servicePath}/api/Chat/SendMessage", HttpMethod.Post, out _, requestObj: requestObj);
            return  true;
        }

        public static bool ReadMessage(string chatID, int messageID)
        {
            JObject requestObj = new JObject()
            {
                { "ChatID", chatID },
                { "MessageID", messageID }
            };
            //return ClassHelper.ServerRequest($"{ClassHelper.servicePath}/api/Chat/ReadMessage", HttpMethod.Post, out _, requestObj: requestObj);
            return true;
        }
    }
}
