using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;

namespace Terminal.Library.ViewModel
{
    public class ChatMainViewModel : ModelBase
    {
        //private List<EmojiModel> emojis;

        public string ChatID { get; set; }

        //public List<EmojiModel> Emojis
        //{
        //    get => emojis;
        //    set
        //    {
        //        emojis = value;
        //        OnPropertyChanged(nameof(Emojis));
        //    }
        //}

        public override void InitializeVariable()
        {
            ChatID = string.Empty;
            //Emojis = null;
        }
    }
}
