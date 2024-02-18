using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace HospitalAppWPF.ViewModels.DoctorViewModels
{
    class AllAppointmentsListViewModel : NotificationService
    {
        private AppointmentRepository appointmentRepository;

        public AppointmentRepository AppointmentRepository
        {
            get { return appointmentRepository; }
            set { appointmentRepository = value; OnPropertyChanged(); }
        }

        private ICollection<Appointment> appointments_notcon;

        public ICollection<Appointment> Appointments_notcon
        {
            get { return appointments_notcon; }
            set { appointments_notcon = value; OnPropertyChanged(); }
        }


        public ICommand close_command { get; set; }
        private ICollection<Appointment> appointments_confirmed;

        public ICollection<Appointment> Appointments_confirmed
        {
            get { return appointments_confirmed; }
            set { appointments_confirmed = value; OnPropertyChanged(); }
        }


        public ICommand confirmbtn { get; set; }
        public ICommand backbtn { get; set; }

        private Doctor doctor1;

        public Doctor Doctor
        {
            get { return doctor1; }
            set { doctor1 = value; }
        }


        public AllAppointmentsListViewModel(Doctor doctor)
        {
            AppointmentRepository = new AppointmentRepository();
            Appointments_confirmed = new ObservableCollection<Appointment>();
            Appointments_confirmed = AppointmentRepository.getDoctorAppo(doctor);
            Appointments_notcon = new ObservableCollection<Appointment>();
            Appointments_notcon = AppointmentRepository.getDoctorApponotc(doctor);
            confirmbtn = new RelayCommand(confirm_appo!);
            Doctor = doctor;
            backbtn = new RelayCommand(go_back!);
            close_command = new RelayCommand(close!);

        }

        public void close(object pa)
        {

            Window? window = pa as Window;
            if (window != null)
            {
                window.Close();
            }
        }

        public void go_back(object pa) 
        {
            if (pa is Page page)
            {
                page.NavigationService.GoBack();
            }
        }



        public void confirm_appo(object pa)
        {
            Appointment appointment = AppointmentRepository.GetById((int)pa);
            if (appointment != null)
            {
                appointment!.IsConfirmed = true;
                AppointmentRepository.Update(appointment);
                AppointmentRepository.SaveChanges();
                Appointments_notcon = AppointmentRepository.getDoctorApponotc(Doctor);
                Appointments_confirmed = AppointmentRepository.getDoctorAppo(Doctor);
            }
            else
                MessageBox.Show("ss");

        }
    }
}
