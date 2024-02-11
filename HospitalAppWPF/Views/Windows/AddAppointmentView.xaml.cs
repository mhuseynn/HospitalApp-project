using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HospitalAppWPF.Views.Windows
{
    /// <summary>
    /// Interaction logic for AddAppointmentView.xaml
    /// </summary>
    public partial class AddAppointmentView : Window
    {
        public AddAppointmentView(User user,Doctor doctor)
        {
            InitializeComponent();
            DataContext=new AddAppointmentViewModel(user, doctor);
        }
    }
}
