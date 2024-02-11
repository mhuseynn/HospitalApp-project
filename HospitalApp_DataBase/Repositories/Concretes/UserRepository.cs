using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Concretes;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public User getForlogin(string username, string password)
    {

        var user = _context?.Users.FirstOrDefault(x => x.UserName == username && x.Password == password);
        return user;

    }
}
