using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.VisualBasic;

namespace BookNest.Data.Repository;

public class MemberRepository : GenaricRepository<Member>, IMemberRepository
{
    private readonly BookNestDbContext _context;
    public MemberRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public Member? SearchByFirstName(string firstName)
    {
        return _context.Members.FirstOrDefault(m => m.FirstName == firstName);
    }
}
