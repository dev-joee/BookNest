using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest.Services.Service;

public class UserRecordService : IUserRecordService
{
    private readonly IUserRecordRepositoy _userRecordRepositoy;
    public UserRecordService(IUserRecordRepositoy userRecordRepositoy)
    {
        _userRecordRepositoy = userRecordRepositoy;
    }
    public void AddActionRecord(UserRecordDTO userRecordDTO)
    {
        var record = new UserRecord
        {
            Action = userRecordDTO.Action,
            ActionDateTime = userRecordDTO.ActionDateTime            
        };

        try
        {
            _userRecordRepositoy.Create(record);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public IEnumerable<UserRecord> GetRecordsHistory()
    {
        return _userRecordRepositoy.GetAll();
    }
}
