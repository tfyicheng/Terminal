using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Library.ViewModel
{
    public   class ChatMessageModel
    {
        // 主键
        public int ID { get; set; }
        // 聊天ID
        public string ChatID { get; set; }
        // 发送方ID
        public string SenderID { get; set; }
        // 接收方ID
        public string ReceiverID { get; set; }
        // 接收方是否已读
        public bool IsRead { get; set; }
        // 消息类型
        public MessageType MessageType { get; set; }
        // 消息内容
        public string MessageContent { get; set; }
        // 消息是否可见（ -1全部可不见, 0全部可见, 1发送方不可见, 2接收方不可见 ）
        public int IsVisible { get; set; }
        // 消息是否撤回
        public bool IsWithdraw { get; set; }
        // 创建时间
        public DateTime CreateTime { get; set; }
        // 首次加载
        public bool LoadFirst { get; set; }
    }
}
