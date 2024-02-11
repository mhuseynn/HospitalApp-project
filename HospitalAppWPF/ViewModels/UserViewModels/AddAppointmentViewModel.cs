using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using System.Windows;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels.UserViewModels
{
    class AddAppointmentViewModel : NotificationService
    {

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

        private Appointment appointment;

        public Appointment Appointment
        {
            get { return appointment; }
            set { appointment = value; OnPropertyChanged(); }
        }

        private AppointmentRepository appointmentRepository;

        public AppointmentRepository AppointmentRepository
        {
            get { return appointmentRepository; }
            set { appointmentRepository = value; }
        }

        public ICommand savebtn {  get; set; }

        public AddAppointmentViewModel(User user,Doctor doctor)
        {
            User = user;
            Doctor = doctor;
            Appointment=new Appointment();
            
            AppointmentRepository = new AppointmentRepository();
            savebtn = new RelayCommand(save_appo!);
            
        }



        public void save_appo(object pa)
        {
            Appointment.DoctorName=Doctor.FirstName + " " + Doctor.LastName;
            Appointment.UserName=User.FirstName + " " + User.LastName;
            Appointment.DoctorId = Doctor.Id;
            Appointment.UserId = User.Id;
            Appointment.IsConfirmed = false;
            AppointmentRepository.Add(Appointment);
            AppointmentRepository.SaveChanges();

            Window window=pa as Window;

            window!.Close();
            
        }
    }
}
