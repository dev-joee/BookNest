using BookNest.Data.Models;
using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface IUserRecordService
{
    void AddActionRecord(UserRecordDTO userRecordDTO);
    IEnumerable<UserRecord> GetRecordsHistory();
}
