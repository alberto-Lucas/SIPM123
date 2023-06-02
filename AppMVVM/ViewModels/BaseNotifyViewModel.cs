using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppMVVM.ViewModels
{
    public abstract class BaseNotifyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //CallerMemberName usado para identificar automatico
        //o nome da propriedade alterada
        public void OnPropertyChanged(
            [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, 
                new PropertyChangedEventArgs(propertyName));
        }
    }
}
