using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.ViewModels.UserViewModels;
using HospitalAppWPF.Views.UserPages;
using HospitalAppWPF.Views.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace HospitalAppWPF.ViewModels;



class LoginPageUserViewModel : NotificationService
{
    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; OnPropertyChanged(); }
    }



    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; OnPropertyChanged(); }
    }

    private string msg;

    public string Msg
    {
        get { return msg; }
        set { msg = value; OnPropertyChanged(); }
    }
    public ICommand loginbtn { get; set; }

    private UserRepository userRepository;

    public UserRepository UserRepository
    {
        get { return userRepository; }
        set { userRepository = value; OnPropertyChanged(); }
    }


    private DoctorRepository doctorRepository;

    public DoctorRepository DoctorRepository
    {
        get { return doctorRepository; }
        set { doctorRepository = value; OnPropertyChanged(); }
    }


    private AdminRepository adminRepository;

    public AdminRepository AdminRepository
    {
        get { return adminRepository; }
        set { adminRepository = value; OnPropertyChanged(); }
    }

    public ICommand backbtn { get; set; }


    public LoginPageUserViewModel(string message)
    {
        msg = message;
        username = "";
        password = "";       
        UserRepository = new UserRepository();
        DoctorRepository= new DoctorRepository();
        AdminRepository = new AdminRepository();
        loginbtn = new RelayCommand(go_profile!);

        backbtn = new RelayCommand(go_back!);
    }


    public void go_back(object pa) 
    {
        if (pa is Page page)
        {
            page.NavigationService.GoBack();
        }
    }

    public void go_profile(object pa)
    {
        if (msg =="User")
        {
            bool ischeck = false;
            User user2 = UserRepository.getForlogin(username!, password!);
            if (user2 != null)
            {
                ischeck = true;
            }
            if (ischeck)
            {
                Page? page = pa as Page;
                NavigationWindow window = new MotherWindowView(user2!);
                username = "";
                password = "";
                NavigationWindow intro_window = (NavigationWindow)NavigationWindow.GetWindow(page);
                //intro_window.Close();
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("sehv");
            }
        }
        else if (msg=="Doctor")
        {
            bool ischeck = false;
            Doctor doctor = DoctorRepository.getForlogin(username!, password!);
            if (doctor != null)
            {
                ischeck = true;
            }
            if (ischeck)
            {
                Page? page = pa as Page;
                NavigationWindow window = new MotherWindowDoctorView(doctor!);
                username = "";
                password = "";
                NavigationWindow intro_window = (NavigationWindow)NavigationWindow.GetWindow(page);
                //intro_window.Close();
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("sehv");
            }
        }
        else if(msg== "Admin")
        {
            bool ischeck = false;
            Admin admin = AdminRepository.getForlogin(username!, password!);
            if (admin != null)
            {
                ischeck = true;
            }
            if (ischeck)
            {
                Page? page = pa as Page;
                NavigationWindow window = new MotherWindowAdminView(admin!);
                username = "";
                password = "";
                NavigationWindow intro_window = (NavigationWindow)NavigationWindow.GetWindow(page);
                //intro_window.Close();
                window.ShowDialog();
            }
            else
            {
                MessageBox.Show("sehv");
            }
        }
    }




}
