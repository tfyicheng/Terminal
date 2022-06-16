﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal.Library
{
    public class MessageBoxButtonModel
    {
        // 按钮提示信息
        public string Hint { get; set; }
        // 按钮点击后需要执行的事件(默认使用异步执行)
        public Action Action { get; set; }
    }
}
