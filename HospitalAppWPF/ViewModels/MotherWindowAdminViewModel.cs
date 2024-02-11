using HospitalApp_Model.Entities.Concretes;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace HospitalAppWPF.ViewModels;

class MotherWindowAdminViewModel
{
	private Admin admin;

	public Admin Admin
	{
		get { return admin; }
		set { admin = value; }
	}



	public MotherWindowAdminViewModel(Admin admin)
    {
        Admin=admin;
		
    }
}
