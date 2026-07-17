using BookNest.Data.Models.Enums;

namespace BookNest.Services.DTOs;

public class UserRecordDTO
{
    public EnAction Action { get; set; }
    public DateTime ActionDateTime { get; set; }
}
