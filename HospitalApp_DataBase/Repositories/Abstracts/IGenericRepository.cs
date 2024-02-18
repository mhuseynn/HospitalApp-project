using HospitalApp_Model.Entities.Abstracts;

namespace HospitalApp_DataBase.Repositories.Abstracts;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    void Remove(int id);
    T? GetById(int id);

    T? getitem(T entitys);
    ICollection<T>? GetAll();
    void SaveChanges();
}
