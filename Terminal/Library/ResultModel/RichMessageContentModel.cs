using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;

namespace Terminal.Library.ResultModel
{
    internal class RichMessageContentModel
    {
        public ClassHelper.RichMessageType MessageType { get; set; }
        public string Content { get; set; }
        public FileModel FileAttribute { get; set; }
    }
}
