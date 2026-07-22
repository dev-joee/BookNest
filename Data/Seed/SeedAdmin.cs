using BookNest.Data.Identity;
using BookNest.Data.Validation;
using Microsoft.AspNetCore.Identity;

namespace BookNest;

public class SeedAdmin
{
    public static async Task SeedAdminAsync(UserManager<BookNestUser> userManager)
    {
        const string email = "admin@booknest.com";
        const string password = "Admin123!";

        var admin = await userManager.FindByEmailAsync(email);

        if (admin == null)
        {
            admin = new BookNestUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(admin, password);

            if (!result.Succeeded)
            {
                throw new Exception(string.Join(
                    Environment.NewLine,
                    result.Errors.Select(e => e.Description)));
            }

            await userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}
