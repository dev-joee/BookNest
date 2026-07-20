using BookNest.Data.Models;

public interface IAuthorRepository : IGenaricRepository<Author>
{
    Task<Author?> SearchByNameAsync(string name);
}