using HospitalApp_Model.Entities.Abstracts;
using System.ComponentModel;

namespace HospitalApp_Model.Entities.Concretes;

public class Appointment : BaseEntity
{
    

    public string? DoctorName { get; set; }

    public string? UserName { get; set; }

    public DateTime Datetime { get; set; }

    [DefaultValue(false)]
    public bool? IsConfirmed { get; set; }   

    //Foreign Key
    public int? UserId { get; set; }
    public int? DoctorId { get; set; }

    //Navigation Property
    public virtual Doctor? Doctor { get; set; }
    public virtual User? User { get; set; }

}
