﻿using HospitalApp_Model.Entities.Concretes;
using HospitalAppWPF.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HospitalAppWPF.Views.Windows
{
    
    public partial class MotherWindowDoctorView : NavigationWindow
    {
        public MotherWindowDoctorView(Doctor doctor)
        {
            InitializeComponent();
            DataContext = new MotherWindowDoctorViewModel(doctor);
        }
    }
}
