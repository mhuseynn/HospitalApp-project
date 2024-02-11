using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Concretes;

public class DoctorRepository : GenericRepository<Doctor> , IDoctorRepository 
{
    public Doctor getForlogin(string username, string password)
    {

        var doctor = _context?.Doctors.FirstOrDefault(x => x.UserName == username && x.Password == password);
        return doctor;

    }
}
