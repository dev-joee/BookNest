using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.VisualBasic;

namespace BookNest.Data.Repository;

public class UserRecordRepositoy : GenaricRepository<UserRecord>, IUserRecordRepositoy
{
    private readonly BookNestDbContext _context;
    public UserRecordRepositoy(BookNestDbContext context) : base(context)
    {
        _context = context;
    }
}
