using AspThesisPro.Models;
using AspThesisPro.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace AspThesisPro.Data
{
    public static class ApplicationDbContextSeed
    {

        public static async Task SeedIdentityRolesAsync(RoleManager<MyIdentityRole> rolemanager)
        {
            foreach (MyIdentityRoleNames role in Enum.GetValues(typeof(MyIdentityRoleNames)))
            {
                string rolename = role.ToString();
                if (!await rolemanager.RoleExistsAsync(rolename))
                {
                    await rolemanager.CreateAsync(
                        new MyIdentityRole { Name = rolename });
                }
            }
        }


        public static async Task SeedIdentityUserAsync(UserManager<MyIdentityUser> usermanager)
        {
            MyIdentityUser user;

            user = await usermanager.FindByNameAsync("admin@thesis.com");
            if (user == null)
            {
                user = new MyIdentityUser()
                {
                    UserName = "admin@thesis.com",
                    Email = "admin@thesis.com",
                    EmailConfirmed = true,
                    DisplayName = "The Admin User",
                    Gender = MyIdentityGenders.Male
                };
                await usermanager.CreateAsync(user, password: "Pass@1234");
                await usermanager.AddToRolesAsync(user, new string[] {
                    MyIdentityRoleNames.Admin.ToString(),
                    MyIdentityRoleNames.Faculty.ToString()
                });
            }
        }

    }
}