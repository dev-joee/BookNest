using BookNest.Data.Identity;
using BookNest.Services.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BookNest.Services;

public class AccountService
{
    private readonly UserManager<BookNestUser> _userManager;
    private readonly SignInManager<BookNestUser> _signInManager;
    public AccountService(UserManager<BookNestUser> userManager, SignInManager<BookNestUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }
    public async Task<IdentityResult> Register(RegisterUserDTO registerUserDTO)
    {
        var user = new BookNestUser
        {
            UserName = registerUserDTO.UserName,
            Email = registerUserDTO.Email,
            Role = registerUserDTO.Role,
        };

        return await _userManager.CreateAsync(user, registerUserDTO.Password);
    }
    public async Task<SignInResult> Login(LoginUserDTO loginUserDTO)
    {
        return await _signInManager.PasswordSignInAsync(loginUserDTO.UserName, loginUserDTO.Password, loginUserDTO.RememberMe, lockoutOnFailure:false);
    }
    public async Task Logout()
    {
        await _signInManager.SignOutAsync();
    }
}
