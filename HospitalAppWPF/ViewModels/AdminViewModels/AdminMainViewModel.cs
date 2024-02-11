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

    public ICommand add_userbtn {  get; set; }

    public ICommand see_doctorsbtn { get; set; }

    public ICommand add_doctorbtn { get; set; }

    public ICommand test {  get; set; }
    public AdminMainViewModel()
    {
        see_usersbtn = new RelayCommand(go_users_page!);
        test = new RelayCommand(test2!);
        add_userbtn = new RelayCommand(add_user!);
        see_doctorsbtn = new RelayCommand(go_doctors_page!);
        add_doctorbtn = new RelayCommand(add_doctor!);
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

    public void add_doctor(object pa)
    {
        if (pa is Page page)
        {
            var newp = new AddDoctorPageView();
            newp.DataContext=new AddDoctorPageViewModel();
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



    public void add_user(object pa)
    {
        if (pa is Page page)
        {
            Page newpage=new AddUserPageView();
            newpage.DataContext= new AddUserPageViewModel();
            page.NavigationService.Navigate(newpage);
        }
    }



    public void test2(object pa)
    {
        MessageBox.Show("masmqskdnfsjdf");
    }
}
