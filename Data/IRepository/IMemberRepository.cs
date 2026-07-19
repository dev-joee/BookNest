using BookNest.Data.Models;

namespace BookNest.Data.IRepository;

public interface IMemberRepository : IGenaricRepository<Member>
{
    Member? SearchByFirstName(string firstName);
}