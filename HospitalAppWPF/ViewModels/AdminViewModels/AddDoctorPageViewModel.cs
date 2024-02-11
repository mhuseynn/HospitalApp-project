using HospitalApp_DataBase.Repositories.Concretes;
using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace HospitalAppWPF.ViewModels.AdminViewModels;

public class AddDoctorPageViewModel : NotificationService
{
    private Doctor doctor;

    public Doctor Doctor
    {
        get { return doctor; }
        set { doctor = value; OnPropertyChanged(); }
    }

    public ICommand save_btn { get; set; }
    public ICommand backbtn { get; set; }


    private DoctorRepository doctorRepository;

    public DoctorRepository DoctorRepository
    {

        get { return doctorRepository; }
        set { doctorRepository = value; OnPropertyChanged(); }
    }

    public AddDoctorPageViewModel()
    {
        Doctor = new Doctor();
        DoctorRepository = new DoctorRepository();
        save_btn = new RelayCommand(add_doctor!);
        backbtn = new RelayCommand(back_go!);
    }

    public void add_doctor(object pa)
    {
        MessageBox.Show("salam");
        DoctorRepository.Add(Doctor);
        DoctorRepository.SaveChanges();
        
        Doctor = new Doctor();
    }

    public void back_go(object pa)
    {
        if (pa is Page page)
        {
            page.NavigationService.GoBack();
        }
    }
}
