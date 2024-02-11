using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.ViewModels.UserViewModels;
using HospitalAppWPF.Views.UserPages;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels;


class MotherWindowViewModel : NotificationService
{
    private User user;

    public User User
    {
        get { return user; }
        set { user = value; OnPropertyChanged(); }

    }
    public ICommand doctorsbtn { get; set; }


    public ICommand appolistbtn { get; set; }
    public MotherWindowViewModel(User user)
    {
        User = user;
        doctorsbtn = new RelayCommand(go_doctors!);
        appolistbtn = new RelayCommand(go_appo_list);
    }

   
    public void go_doctors(object pa)
    {
        if (pa is Frame fr)
        {
            var newp = new DoctorsPageView();
            newp.DataContext = new DoctorsPageViewModel(User);
            fr.NavigationService.Navigate(newp);
        }
    }


    public void go_appo_list(object pa)
    {
        if (pa is Frame fr)
        {
            var newp = new AllAppointmentsView();
            newp.DataContext = new AllAppointmentsViewModel(User);
            fr.NavigationService.Navigate(newp);
        }
    }
}
