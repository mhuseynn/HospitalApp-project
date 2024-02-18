using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.Views.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace HospitalAppWPF.ViewModels.UserViewModels;

public class DoctorsPageViewModel : NotificationService
{

    private DoctorRepository doctorRepository;

    public DoctorRepository DoctorRepository
    {

        get { return doctorRepository; }
        set { doctorRepository = value; OnPropertyChanged(); }
    }

    private ICollection<Doctor> doctors;

    public ICollection<Doctor> Doctors
    {
        get { return doctors; }
        set { doctors = value; }
    }

    private User user;

    public User User
    {
        get { return user; }
        set { user = value; OnPropertyChanged(); }
    }

    private Doctor doctor;

    public Doctor Doctor
    {
        get { return doctor; }
        set { doctor = value; OnPropertyChanged(); }
    }

    public ICommand appobtn { get; set; }
    public ICommand backbtn { get; set; }

    public DoctorsPageViewModel(User user)
    {
        User = user;
        Doctor = new Doctor();
        DoctorRepository = new DoctorRepository();
        Doctors = new ObservableCollection<Doctor>();
        Doctors = DoctorRepository.GetAll()!;
        appobtn = new RelayCommand(go_add_appo!);
        backbtn = new RelayCommand(go_back!);
    }

    public void go_add_appo(object pa)
    {
        Doctor = (Doctor)(DoctorRepository.GetById((int)pa))!;
        Window window = new AddAppointmentView(User, Doctor);
        window.ShowDialog();
    }

    public void go_back(object pa)
    {
        Window? window = pa as Window;
        if (window != null)
        {
            window.Close();
        }
    }


}
