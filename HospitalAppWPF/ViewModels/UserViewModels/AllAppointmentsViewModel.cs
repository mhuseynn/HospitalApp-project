using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HospitalAppWPF.ViewModels.UserViewModels;

class AllAppointmentsViewModel:NotificationService
{


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
        set { appointments = value;OnPropertyChanged(); }
    }
    public AllAppointmentsViewModel(User user)
    {
        AppointmentRepository=new AppointmentRepository();
        Appointments=new ObservableCollection<Appointment>();
        Appointments = AppointmentRepository.getUserAppo(user);

    }
}
