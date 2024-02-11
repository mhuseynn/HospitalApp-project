using HospitalApp_Model.Entities.Abstracts;

namespace HospitalApp_Model.Entities.Concretes;

public class Analiz : BaseEntity
{

    public string? Name { get; set; }

    public string? Description { get; set; }

    //Foreign Key
    public int? UserId { get; set; }

    public int? DoctorId { get; set; }

    //Navigation Property
    public virtual  Doctor? Doctor { get; set; }
           
    public virtual User? User { get; set; }
}
