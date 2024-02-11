using HospitalApp_Model.Entities.Abstracts;
using HospitalApp_Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAppWPF.Models
{
    public class MyUser
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }


        //Navigation Property
        public virtual ICollection<Analiz>? Analyses { get; set; }

        public virtual ICollection<Appointment>? Appointments { get; set; }


        public override string ToString()
        {

            return $"{FirstName} - {LastName}-{UserName}";
        }


    }
}
