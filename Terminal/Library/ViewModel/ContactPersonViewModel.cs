using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Common;
using Terminal.Library.ResultModel;

namespace Terminal.Library.ViewModel
{
    public class ContactPersonViewModel : ModelBase
    {
        private bool slidingBlockState;
        private List<FriendSortModel> friends;
        //private List<NewFriendBriefModel> newFriends;

        public bool SlidingBlockState
        {
            get => slidingBlockState;
            set
            {
                slidingBlockState = value;
                OnPropertyChanged(nameof(SlidingBlockState));
            }
        }
        public List<FriendSortModel> Friends
        {
            get => friends;
            set
            {
                friends = value;
                OnPropertyChanged(nameof(Friends));
            }
        }
        //public List<NewFriendBriefModel> NewFriends
        //{
        //    get => newFriends;
        //    set
        //    {
        //        newFriends = value;
        //        OnPropertyChanged(nameof(NewFriends));
        //    }
        //}

        public override void InitializeVariable()
        {
            slidingBlockState = true;
            friends = null;
            //newFriends = null;
        }
    }
}
