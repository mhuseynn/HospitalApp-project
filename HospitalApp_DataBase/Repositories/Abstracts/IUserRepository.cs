using HospitalApp_Model.Entities.Concretes;

namespace HospitalApp_DataBase.Repositories.Abstracts;

public interface IUserRepository : IGenericRepository<User>
{
     User getForlogin(string username,string password);
}
