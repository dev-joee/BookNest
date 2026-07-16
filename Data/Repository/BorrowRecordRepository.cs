using BookNest.Data.IRepository;
using BookNest.Data.Models;

namespace BookNest.Data.Repository;

public class BorrowRecordRepository : GenaricRepository<BorrowRecord>, IBorrowRecordRepository
{
    private readonly BookNestDbContext _context;
    public BorrowRecordRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }
}
