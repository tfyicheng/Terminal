﻿using System;
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


        //获取聊天列表数据


        public static bool GetChatColumnInfo(out List<ChatColumnInfoModel> chatColumnInfos)
    {
        chatColumnInfos = null;
        if (true)
        {
            //chatColumnInfos = JsonConvert.DeserializeObject<List<ChatColumnInfoModel>>(res);
            chatColumnInfos = new List<ChatColumnInfoModel>();
                ChatColumnInfoModel a = new ChatColumnInfoModel() { NickName = "123",ChatID="1",FriendID="3" };
                ChatColumnInfoModel b = new ChatColumnInfoModel() { NickName = "456",ChatID="2", FriendID = "4" };
                chatColumnInfos.Add(a); 
                chatColumnInfos.Add(b);
                return true;
        }
  
    }

    //根据id获取聊天信息
    public static bool GetChattingRecords(string chatID, out List<ChatMessagesModel> chatMessages)
    {
        chatMessages = null;
        if (true)
        {
            //chatMessages = JsonConvert.DeserializeObject<List<ChatMessageModel>>(resp);\
             chatMessages = new List<ChatMessagesModel>();
                ChatMessagesModel a = new ChatMessagesModel() { ChatID = "1" ,MessageContent="666",SenderID="3",ReceiverID="0",IsRead=true,MessageType=0,IsVisible=0 };
                //ChatMessagesModel b = new ChatMessagesModel() { ChatID = "1", MessageContent = "888", SenderID = "0", ReceiverID = "3" };
              chatMessages.Add(a); 
                //chatMessages.Add(b);
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
