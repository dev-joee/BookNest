using BookNest.Data.IRepository;
using BookNest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookNest.Data.Repository;

public class BorrowRecordRepository : GenaricRepository<BorrowRecord>, IBorrowRecordRepository
{
    private readonly BookNestDbContext _context;

    public BorrowRecordRepository(BookNestDbContext context) : base(context)
    {
        _context = context;
    }

    public IEnumerable<BorrowRecord> GetActiveByMemberAsync(int memberId)
    {
        return _context.BorrowRecords.Where(br => br.MemberId == memberId);
    }

    public async Task<IEnumerable<UserRecord>> GetHistory()
    {
        return await _context.UserRecords.ToListAsync();
    }
    public async Task<int> CountByActiveMembers()
    {
        return await _context.BorrowRecords.CountAsync(br => br.MemberId != 0);
    }
}