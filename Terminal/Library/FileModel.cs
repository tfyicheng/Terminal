using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;

namespace Terminal.Library
{
    internal class FileModel
    {
        public ClassHelper.FileType FileType { get; set; }
        public string FileName { get; set; }
        public double FileMByte { get; set; }
        public double FileWidth { get; set; }
        public double FileHeight { get; set; }
    }
}