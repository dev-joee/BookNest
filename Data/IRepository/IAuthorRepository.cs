using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface IAuthorRepository : IGenaricRepository<Author>
{
    Author? SearchByName(string name);
}
