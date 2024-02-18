using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.Views.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels.UserViewModels;

class AllAppointmentsViewModel : NotificationService
{
    public ICommand backbtn { get; set; }

    private AppointmentRepository appointmentRepository;

    public AppointmentRepository AppointmentRepository
    {
        get { return appointmentRepository; }
        set { appointmentRepository = value; }
    }

    private ICollection<Appointment> appointments;

    public ICollection<Appointment> Appointments
    {
        get { return appointments; }
        set { appointments = value; OnPropertyChanged(); }
    }


    private ICollection<Appointment> appointmentsconfirmed;

    public ICollection<Appointment> AppointmentsConfirmed
    {
        get { return appointmentsconfirmed; }
        set { appointmentsconfirmed = value; OnPropertyChanged(); }
    }


    private ICollection<Appointment> appointments_notconfirmed;

    public ICollection<Appointment> AppointmentsNotConfirmed
    {
        get { return appointments_notconfirmed; }
        set { appointments_notconfirmed = value; OnPropertyChanged(); }
    }

    private User user;

    public User User
    {
        get { return user; }
        set { user = value; }
    }

    public AllAppointmentsViewModel(User user)
    {
        AppointmentsNotConfirmed = new ObservableCollection<Appointment>();
        AppointmentRepository = new AppointmentRepository();
        AppointmentsConfirmed = new ObservableCollection<Appointment>();

        AppointmentsConfirmed = AppointmentRepository.getUserAppo(user);

        AppointmentsNotConfirmed = AppointmentRepository.getUserApponotc(user);



        backbtn = new RelayCommand(go_back!);
        User = user;
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
