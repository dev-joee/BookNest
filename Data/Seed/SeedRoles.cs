using Microsoft.AspNetCore.Identity;

namespace BookNest.Data.Seed;

public class SeedRoles
{
    public async Task seedRoles(RoleManager<IdentityRole> roleManager)
    {
        string [] roles = {
            "Admin",
            "Member",
            "Librarian"
        };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
            else
                throw new Exception($"Role {role} Already Exists");
        }
    }
}
