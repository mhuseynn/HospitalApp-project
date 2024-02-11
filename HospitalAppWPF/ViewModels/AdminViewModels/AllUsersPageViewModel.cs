using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.Views.AdminPages;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels.AdminViewModels;

public class AllUsersPageViewModel : NotificationService
{
    private UserRepository userRepository;

    public UserRepository UserRepository
    {

        get { return userRepository; }
        set { userRepository = value; OnPropertyChanged(); }
    }


    private GenericRepository<User> genericRepository;

    public GenericRepository<User> GenericRepository
    {

        get { return genericRepository; }
        set { genericRepository = value; OnPropertyChanged(); }
    }

    private ICollection<User> users;

    public ICollection<User> Users
    {
        get { return users; }
        set { users = value; OnPropertyChanged(); }
    }



    private User user;

    public User User
    {
        get { return user; }
        set { user = value; OnPropertyChanged(); }
    }


    public ICommand removebtn { get; set; }


    public ICommand editbtn { get; set; }

    public ICommand savebtn { get; set; }
    public ICommand backbtn { get; set; }
    public AllUsersPageViewModel()
    {
        UserRepository = new UserRepository();
        Users = new ObservableCollection<User>(UserRepository.GetAll()!);
        removebtn = new RelayCommand(remove_user!);
        User = new User();
        editbtn = new RelayCommand(edit_user!);
        savebtn = new RelayCommand(save_changes);
        backbtn = new RelayCommand(go_back);

    }


    public void remove_user(object pa)
    {
        User userremove = UserRepository.GetById((int)pa)!;

        if (userremove != null)
        {
            Users.Remove(userremove);
            UserRepository.Remove((int)pa);
            UserRepository.SaveChanges();
            MessageBox.Show("sss");
        }
        else
            MessageBox.Show("nulld");
    }

    public void edit_user(object pa)
    {
        User = UserRepository.GetById((int)pa)!;

    }

    public void save_changes(object pa)
    {
        foreach (var item in users)
        {
            if (item.FirstName == User.FirstName && item.LastName == User.LastName && item.UserName == User.UserName)
            {
                item.FirstName = User.FirstName;
                item.LastName = User.LastName;
                item.UserName = User.UserName;
            }

        }
        UserRepository.Update(User);
        UserRepository.SaveChanges();
        User = new User();
    }


    public void go_back(object pa) 
    {
        if (pa is Page page)
        {
            page.NavigationService.GoBack();
        }
    }




}
