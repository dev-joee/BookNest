using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface ICategoryRepository : IGenaricRepository<Category>
{
    Category? SearchByName(string name);
}
