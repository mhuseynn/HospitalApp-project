using HospitalApp_Model.Entities.Concretes;
using System.Windows.Navigation;
using HospitalAppWPF.ViewModels;

namespace HospitalAppWPF.Views.Windows
{

    public partial class MotherWindowView : NavigationWindow
    {

        public MotherWindowView(User user)
        {
            InitializeComponent();
            DataContext = new MotherWindowViewModel(user);
        }

        
    }
}
