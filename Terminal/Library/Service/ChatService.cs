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
using System.Data.SQLite;
using System.Windows;
using Terminal.DB;

namespace Terminal.Library.Service
{
    public static class ChatService
    {

        //新增聊天或者跳转到聊天
        public static bool AddChat(string friendID)
        {
            JObject requestObj = new JObject()
            {
                { "FriendID", friendID }
            };
            return true;
        
        }


        //获取聊天列表数据
        public static bool GetChatColumnInfo(out List<ChatColumnInfoModel> chatColumnInfos)
    {

        if (true)
        {
            //chatColumnInfos = JsonConvert.DeserializeObject<List<ChatColumnInfoModel>>(res);
            chatColumnInfos = new List<ChatColumnInfoModel>();
                ChatColumnInfoModel a = new ChatColumnInfoModel() { NickName = "测试用户一",ChatID="1",FriendID="3" };
                ChatColumnInfoModel b = new ChatColumnInfoModel() { NickName = "测试用户二",ChatID="2", FriendID = "4" };
                chatColumnInfos.Add(a); 
                chatColumnInfos.Add(b);
                return true;
        }
  
    }

    //根据id获取聊天信息
    public static bool GetChattingRecords(string chatID, out List<ChatMessagesModel> chatMessages)
    {

   chatMessages = new List<ChatMessagesModel>();
            if (chatID == "1")
        {
            //chatMessages = JsonConvert.DeserializeObject<List<ChatMessageModel>>(resp);\
          
                ChatMessagesModel a = new ChatMessagesModel() { ChatID = "1" ,MessageContent="666",SenderID="3",ReceiverID="0",IsRead=true,MessageType=0,IsVisible=0 };
                ChatMessagesModel b = new ChatMessagesModel() { ChatID = "1", MessageContent = "888", SenderID = "0", ReceiverID = "3" };
                ChatMessagesModel c = new ChatMessagesModel() { ChatID = "1", MessageContent = "的苦涩和分离四级分数分类为解放路色剂历史记录蒙娜丽莎呢服了你\t\n力所能及馥蕾诗家乐福建安我放假了案例进屋里你发了发怒", SenderID = "0", ReceiverID = "3" };
                ChatMessagesModel d = new ChatMessagesModel() { ChatID = "1", MessageContent = "的苦涩和分离四级分数分类为解放路色剂历史记录蒙娜丽莎呢服了你\t\n力所能及馥蕾诗家乐福建安我放假了案例进屋里你发了发怒", SenderID = "3", ReceiverID = "3" };
                ChatMessagesModel e = new ChatMessagesModel() { ChatID = "1", MessageContent = "的苦涩和分离四级分数分", SenderID = "0", ReceiverID = "3" };

                chatMessages.Add(a);
                chatMessages.Add(b);
                chatMessages.Add(c); chatMessages.Add(d); chatMessages.Add(e);

               /// MySqliteHelper.CreateDataBase();
               //MySqliteHelper.CreateDatabaseConnection();
                //MySqliteHelper.Open(MySqliteHelper.connection);
                return true;          
             
            }
            else
            {
               
                ChatMessagesModel a = new ChatMessagesModel() { ChatID = "2", MessageContent = "96554", SenderID = "4", ReceiverID = "0", IsRead = true, MessageType = 0, IsVisible = 0 };
                ChatMessagesModel b = new ChatMessagesModel() { ChatID = "2", MessageContent = "苦涩和分离四级分数分类为解放路色剂历史记", SenderID = "0", ReceiverID = "4" };
                ChatMessagesModel c = new ChatMessagesModel() { ChatID = "2", MessageContent = "放路色剂历史记录蒙娜丽莎呢服了你\t\n力所能及馥蕾诗家乐福建安我放假了案例进屋里你发了发怒", SenderID = "0", ReceiverID = "4" };
                ChatMessagesModel d = new ChatMessagesModel() { ChatID = "2", MessageContent = "2的苦涩和分离四级分数分类为解放路色剂历史记录蒙娜丽莎呢服了你\t\n力所能及馥蕾诗家乐福建安我放假了案例进屋里你发了发怒", SenderID = "3", ReceiverID = "4" };
                ChatMessagesModel e = new ChatMessagesModel() { ChatID = "2", MessageContent = "666666", SenderID = "0", ReceiverID = "4" };

                chatMessages.Add(a);
                chatMessages.Add(b);
                chatMessages.Add(c); chatMessages.Add(d); chatMessages.Add(e);
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
          
            return  true;
        }

        public static bool ReadMessage(string chatID, int messageID)
        {
            JObject requestObj = new JObject()
            {
                { "ChatID", chatID },
                { "MessageID", messageID }
            };
           
            return true;
        }


    }
}
