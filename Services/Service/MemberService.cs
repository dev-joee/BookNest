using BookNest.Data.IRepository;
using BookNest.Data.Models;
using BookNest.Services.DTOs;
using BookNest.Services.IService;

namespace BookNest;

public class MemberService : IMemberService
{
    private readonly IMemberRepository _memberRepository;
    public MemberService(IMemberRepository memberRepository)
    {
        _memberRepository = memberRepository;
    }

    private Member AssembleMember(MemberDTO memberDTO, int id = 0)
    {
        return new Member
        {
            Id = id,
            FirstName = memberDTO.MemberFirstName,
            LastName = memberDTO.MemberLastName,
            Email = memberDTO.MemberEmail,
            PhoneNumber = memberDTO.MemberPhone,
            Address = memberDTO.MemberAddress,
            DateOfBirth = memberDTO.MemberBirthDate            
        };
    }

    public void Create(MemberDTO newMemberDTO)
    {
        var member  = AssembleMember(newMemberDTO);

        try
        {
            _memberRepository.Create(member);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }

    }

    public void Edit(int id, MemberDTO updatedMemberDTO)
    {
        var member = AssembleMember(updatedMemberDTO, id);

        try
        {
            _memberRepository.Update(member);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            _memberRepository.DeleteById(id);
        }
        catch (Exception ex)
        {
            
            throw new Exception(ex.Message);
        }
    }

    public Member? Search(string firstName)
    {
        return _memberRepository.SearchByFirstName(firstName);
    }
}
