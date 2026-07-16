using BookNest.Data.IRepository;

namespace BookNest.Data.Repository;

public class GenaricRepository<T> : IGenaricRepository<T> where T : class
{
    private readonly BookNestDbContext _context;
    public GenaricRepository(BookNestDbContext context)
    {
        _context = context;
    }
    public void Create(T obj)
    {
        _context.Set<T>().Add(obj);
    }

    public void Delete(T obj)
    {
        _context.Set<T>().Remove(obj);
    }

    public void DeleteById(int id)
    {
        this.Delete(GetById(id));
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T? GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Update(T obj)
    {
        _context.Update(obj);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}
