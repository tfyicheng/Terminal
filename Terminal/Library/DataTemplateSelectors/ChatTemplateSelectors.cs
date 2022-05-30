using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Terminal.Common;
using Terminal.Library.ResultModel;

namespace Terminal.Library.DataTemplateSelectors
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            ChatMessagesModel chatMessages = item as ChatMessagesModel;
            //根据id判断返回哪个数据模版
            return ClassHelper.FindResource<DataTemplate>(chatMessages.SenderID == ClassHelper.UserID ? "MeTemplate" : "OtherTemplate");
        }
    }
}
