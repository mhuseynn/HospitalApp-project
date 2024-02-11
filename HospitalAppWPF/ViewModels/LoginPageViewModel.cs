using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.Views.Pages;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels;


class LoginPageViewModel : NotificationService
{


    public ICommand createbtn { get; set; }
    public ICommand as_userbtn { get; set; }
    public ICommand as_adminbtn { get; set; }
    public ICommand as_doctorbtn { get; set; }

    public LoginPageViewModel()
    {
        createbtn = new RelayCommand(go_signup!);
        as_userbtn = new RelayCommand(go_userlogin!);
        as_adminbtn = new RelayCommand(go_adminlogin!);
        as_doctorbtn = new RelayCommand(go_doctorlogin!);
    }

    public void go_signup(object pa)
    {
        if (pa is Page page)
        {
            var signUpPage = new SignUpPageView();
            signUpPage.DataContext = new SignUpPageViewModel();
            page.NavigationService.Navigate(signUpPage);
        }
    }
    public void go_userlogin(object pa)
    {
        if (pa is Page page)
        {
            var newpage = new LoginPageViewUser();
            newpage.DataContext = new LoginPageUserViewModel("User");
            page.NavigationService.Navigate(newpage);
        }
    }

    public void go_doctorlogin(object pa)
    {
        if (pa is Page page)
        {
            var newpage = new LoginPageViewUser();
            newpage.DataContext = new LoginPageUserViewModel("Doctor");
            page.NavigationService.Navigate(newpage);
        }
    }

    public void go_adminlogin(object pa)
    {
        if (pa is Page page)
        {
            var newpage = new LoginPageViewUser();
            newpage.DataContext = new LoginPageUserViewModel("Admin");
            page.NavigationService.Navigate(newpage);
        }
    }

}
