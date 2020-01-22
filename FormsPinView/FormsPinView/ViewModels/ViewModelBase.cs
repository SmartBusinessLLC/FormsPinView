using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FormsPinView.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string key = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
        }

        protected void RaisePropertiesChanged(params string[] keys)
        {
            if (keys != null)
            {
                foreach (string key in keys)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
                }
            }
        }
    }

}