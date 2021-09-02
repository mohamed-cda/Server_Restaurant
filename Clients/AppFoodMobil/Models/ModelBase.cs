using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppFoodMobil.Models
{
   public  abstract class ModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnpropertyChanged([CallerMemberName] string propertyName = null) =>

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        protected bool Set<T>(ref T storage, T Value,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, Value))
            {
                return false;
            }
            storage = Value;
            OnpropertyChanged(propertyName);
            return true;
        }
    }
}
