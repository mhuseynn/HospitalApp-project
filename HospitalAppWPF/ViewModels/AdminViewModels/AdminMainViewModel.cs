using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.ViewModels.AdminViewModels;
using HospitalAppWPF.Views.AdminPages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels;

class AdminMainViewModel : NotificationService
{


    public ICommand see_usersbtn { get; set; }

    

    public ICommand see_doctorsbtn { get; set; }

   
    public ICommand test {  get; set; }
    public AdminMainViewModel()
    {
        see_usersbtn = new RelayCommand(go_users_page!);
   
        see_doctorsbtn = new RelayCommand(go_doctors_page!);
       
    }


    public void go_users_page(object pa)
    {
        if (pa is Page page)
        {
            var newp = new AllUsersPageView();
            newp.DataContext = new AllUsersPageViewModel();
            page.NavigationService.Navigate(newp);
        }
    }

    

    public void go_doctors_page(object pa)
    {
        if (pa is Page page)
        {
            var newp = new AllDoctorsPageView();
            newp.DataContext = new AllDoctorsPageViewModel();
            page.NavigationService.Navigate(newp);
        }
    }




    
}
