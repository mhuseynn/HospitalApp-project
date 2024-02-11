using HospitalApp_Model.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp_DataBase.Repositories.Abstracts
{
    public interface IAdminRepository : IGenericRepository<Admin>
    {
        Admin getForlogin(string username, string password);
    }
}
