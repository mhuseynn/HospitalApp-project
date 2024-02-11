using HospitalApp_Model.Entities.Abstracts;
using System.ComponentModel;

namespace HospitalApp_Model.Entities.Concretes;

public class Doctor : BaseEntity
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    //Forign Key
    
    public int? DepartmentId{ get; set; }

    public virtual ICollection<Appointment>? Appointments { get; set; }

    public virtual ICollection<Analiz>? Analyses { get; set; }

    public virtual Department? Department { get; set; }

}
