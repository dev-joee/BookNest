using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BookNest.Data.Repository;

public class MemberRepository : GenaricRepository<Member>, IMemberRepository
{
    private readonly BookNestDbContext _context;
    public MemberRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Member?> SearchByFirstNameAsync(string firstName)
    {
        return await _context.Members.FirstOrDefaultAsync(m => m.FirstName == firstName);
    }
}
