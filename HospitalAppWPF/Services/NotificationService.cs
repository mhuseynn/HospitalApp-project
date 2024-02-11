using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HospitalAppWPF.Services;

public abstract class NotificationService : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string property_name = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property_name));
}
