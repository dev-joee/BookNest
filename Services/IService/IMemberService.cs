using BookNest.Data.Models;
using BookNest.Services.DTOs;

namespace BookNest.Services.IService;

public interface IMemberService
{
    void Create(MemberDTO newMemberDTO);
    void Edit(int id, MemberDTO updatedMemberDTO);
    void Delete(int id);
    Member? Search(string firstName);
}