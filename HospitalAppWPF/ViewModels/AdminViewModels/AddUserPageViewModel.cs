using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels.AdminViewModels;

public class AddUserPageViewModel : NotificationService
{
    private User user;

    public User User
    {
        get { return user; }
        set { user = value; OnPropertyChanged(); }
    }

    public ICommand save_btn { get; set; }
    public ICommand backbtn { get; set; }


    private UserRepository userRepository;

    public UserRepository UserRepository
    {

        get { return userRepository; }
        set { userRepository = value; OnPropertyChanged(); }
    }

    public AddUserPageViewModel()
    {
        User = new User();
        UserRepository= new UserRepository();
        save_btn = new RelayCommand(add_user!);
        backbtn = new RelayCommand(back_go!);
    }

    public void add_user(object pa)
    {     
        UserRepository.Add(User);
        UserRepository.SaveChanges();
        MessageBox.Show("salam");
        User = new User();
    }

    public void back_go(object pa) 
    {
        if (pa is Page page)
        {
            page.NavigationService.GoBack();
        }
    }
}
