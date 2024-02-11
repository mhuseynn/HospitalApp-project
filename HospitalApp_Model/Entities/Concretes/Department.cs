using HospitalApp_Model.Entities.Abstracts;

namespace HospitalApp_Model.Entities.Concretes;

public class Department : BaseEntity
{
    public string? Name { get; set; }

    public string? Description { get; set; }



    public virtual ICollection<Doctor>? Doctors { get; set; }
}
