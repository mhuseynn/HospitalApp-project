using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.Commands;
using HospitalAppWPF.Services;
using HospitalAppWPF.ViewModels.DoctorViewModels;
using HospitalAppWPF.Views.DoctorsPages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HospitalAppWPF.ViewModels;

class MotherWindowDoctorViewModel :NotificationService
{
	private Doctor doctor1;

	public Doctor Doctor
	{
		get { return doctor1; }
		set { doctor1 = value; OnPropertyChanged(); }
	}


	public ICommand appolistbtn { get; set; }

	public MotherWindowDoctorViewModel(Doctor doctor) 
    { 
        Doctor = doctor;
		appolistbtn = new RelayCommand(go_appolist!);
    }

	public void go_appolist(object pa) 
	{ 
		if (pa is Frame frame)
		{
			Window page = new AllAppointmentsListView();
			page.DataContext = new AllAppointmentsListViewModel(Doctor);
			page.ShowDialog();
		}
	}


}
