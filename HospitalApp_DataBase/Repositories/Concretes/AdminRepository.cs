using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Concretes
{
    public class AdminRepository: GenericRepository<Admin>,IAdminRepository
    {
        public Admin getForlogin(string username, string password)
        {
            var admin = _context?.Admins!.FirstOrDefault(x => x.UserName == username && x.Password == password);
            return admin!;
        }
    }
}
