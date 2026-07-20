using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface ICategoryRepository : IGenaricRepository<Category>
{
    Task<Category?> SearchByNameAsync(string name);
}