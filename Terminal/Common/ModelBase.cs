using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Terminal.Library.ViewModel;
using System.Collections.ObjectModel;

namespace Terminal.Common
{
    public abstract class ModelBase : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;

        //protected ModelBase()
        //{
        //    InitializeVariable();
        //}

        public abstract void InitializeVariable();

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                 PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
          
        }
    }
}
