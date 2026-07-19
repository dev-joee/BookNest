using BookNest.Services.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BookNest.Services.IService;

public interface IAccountService
{
    Task<IdentityResult> Register(RegisterUserDTO registerUserDTO);
    Task<SignInResult> Login(LoginUserDTO loginUserDTO);
    Task Logout();
}