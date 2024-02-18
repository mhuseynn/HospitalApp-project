using HospitalApp_DataBase.Contexts;
using HospitalApp_DataBase.Repositories.Abstracts;
using HospitalApp_Model.Entities.Abstracts;

namespace HospitalApp_DataBase.Repositories.Concretes;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{

    internal readonly HospitalDB? _context;

    public GenericRepository()
    {
        _context = new HospitalDB();
    }
    public void Add(T entity)
    {
        if (entity is null) throw new Exception(" is NUll");
        _context?.Set<T>().Add(entity);
    }

    public ICollection<T>? GetAll()
    {
        return _context?.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        if (id <= 0) throw new Exception("Id is not valid");
        var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
        return entity;
    }

    public T? getitem(T entitys)
    {
        if (entitys.Id <= 0) throw new Exception("Id is not valid");
        var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == entitys.Id);
        return entity;
    }

    public void Remove(T entity)
    {
        if (entity is null) throw new Exception("entity is NUll");
        _context?.Set<T>().Remove(entity);
    }

    public void Remove(int id)
    {
        if (id <= 0) throw new Exception("Id is not valid");
        var entity = _context?.Set<T>().FirstOrDefault(x => x.Id == id);
        if (entity is null) throw new Exception("entity is NUll");
        _context?.Set<T>().Remove(entity);
    }

    public void SaveChanges()
    {
        _context?.SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity is null) throw new Exception("entity is NUll");
        _context?.Set<T>().Update(entity);
    }
}
