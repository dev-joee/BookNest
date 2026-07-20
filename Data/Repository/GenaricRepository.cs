using BookNest.Data.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data.Repository;

public class GenaricRepository<T> : IGenaricRepository<T> where T : class
{
    private readonly BookNestDbContext _context;

    public GenaricRepository(BookNestDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(T obj)
    {
        await _context.Set<T>().AddAsync(obj);
    }

    public void Delete(T obj)
    {
        _context.Set<T>().Remove(obj);
    }

    public async Task DeleteByIdAsync(int id)
    {
        var entity = await GetByIdAsync(id);

        if (entity != null)
        {
            Delete(entity);
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public void Update(T obj)
    {
        _context.Update(obj);
    }

    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}