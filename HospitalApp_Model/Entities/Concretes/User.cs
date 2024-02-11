using HospitalApp_Model.Entities.Abstracts;

namespace HospitalApp_Model.Entities.Concretes;

public class User : BaseEntity
{
    public string?  FirstName { get; set; }
    
    public string? LastName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }


    //Navigation Property
    public virtual ICollection<Analiz>? Analyses { get; set; }

    public virtual ICollection<Appointment>? Appointments { get; set; }



}
