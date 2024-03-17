using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Explorer.Shared.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged 
    {

        #region events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Protected
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(sender: this, e: new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }

}

