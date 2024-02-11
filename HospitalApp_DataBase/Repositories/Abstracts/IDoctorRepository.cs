using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Abstracts;

public interface IDoctorRepository : IGenericRepository<Doctor>
{
    Doctor getForlogin(string username, string password);
}
