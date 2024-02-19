using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels.AdminViewModels;

public class AllDoctorsPageViewModel : NotificationService
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
        set { doctors = value; OnPropertyChanged(); }
    }


    private Doctor doctor;

    public Doctor Doctor
    {
        get { return doctor; }
        set { doctor = value; OnPropertyChanged(); }
    }


    public ICommand removebtn { get; set; }


    public ICommand editbtn { get; set; }

    public ICommand savebtn { get; set; }
    public ICommand backbtn { get; set; }


    public AllDoctorsPageViewModel()
    {
        DoctorRepository = new DoctorRepository();
        Doctors = new ObservableCollection<Doctor>(DoctorRepository.GetAll()!);
        removebtn = new RelayCommand(remove_doctor!);
        Doctor = new Doctor();
        editbtn = new RelayCommand(edit_doctor!);
        savebtn = new RelayCommand(save_changes!);
        backbtn = new RelayCommand(go_back!);
    }



    public void remove_doctor(object pa)
    {
        ListView listView = pa as ListView;
        Doctor doctorremove = DoctorRepository.getitem(listView.SelectedItem as Doctor)!;

        if (doctorremove != null)
        {
            Doctors.Remove(doctorremove);
            DoctorRepository.Remove(doctorremove.Id);
            DoctorRepository.SaveChanges();
            Doctors = DoctorRepository.GetAll()!;
            MessageBox.Show("silindi");
        }
        else
            MessageBox.Show("nulldur");
    }

    public void edit_doctor(object pa)
    {
        MessageBox.Show("edit");
        ListView listView = pa as ListView;
        Doctor = DoctorRepository.getitem(listView.SelectedItem as Doctor);

    }

    public void save_changes(object pa)
    {
        
        DoctorRepository.Update(Doctor);
        DoctorRepository.SaveChanges();
        Doctors = DoctorRepository.GetAll()!;
        Doctor = new Doctor();
    }


    public void go_back(object pa)
    {
        if (pa is Page page)
        {
            page.NavigationService.GoBack();
        }
    }
}
