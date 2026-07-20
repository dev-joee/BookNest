using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface IMemberRepository : IGenaricRepository<Member>
{
    Task<Member?> SearchByFirstNameAsync(string firstName);
}