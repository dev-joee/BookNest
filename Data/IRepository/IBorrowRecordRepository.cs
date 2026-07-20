using BookNest.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BookNest.Data.IRepository;

public interface IBorrowRecordRepository : IGenaricRepository<BorrowRecord>
{
    IEnumerable<BorrowRecord> GetActiveByMemberAsync(int memberId);
    Task<IEnumerable<UserRecord>> GetHistory();
    Task<int> CountByActiveMembers();
}
