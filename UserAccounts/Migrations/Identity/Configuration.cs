namespace UserAccounts.Migrations.Identity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserAccounts.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<UserAccounts.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(UserAccounts.Models.ApplicationDbContext context)
        {
            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            //const string roleName = "Admin";

            //if (!roleManager.RoleExists(roleName))
            //{
            //    roleManager.Create(new IdentityRole(roleName));

            //}
            //const string roleName2 = "Guest";
            //if (!roleManager.RoleExists(roleName2))
            //{
            //    roleManager.Create(new IdentityRole(roleName2));
            //}
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //string[] emails = { "Karim.lamrini10@gmail.com", "Kareem.lamrini10@gmail.com" };

            //if (userManager.FindByEmail(emails[0]) == null)
            //{
            //    var user = new ApplicationUser() { Email = emails[0], UserName =  emails[0] };
            //    string userPWD = "adminadmin";
            //    var chkUser = userManager.Create(user, userPWD);
            //    if (chkUser.Succeeded)
            //    {
            //        var result1 = userManager.AddToRole(user.Id, "Admin")
            //        ;

            //    }
            //}
            //if (userManager.FindByEmail(emails[1]) == null)
            //{
            //    var user = new ApplicationUser() { Email = emails[1], UserName = emails[1] };
            //    string userPWD = "adminadmin";
            //    var chkUser = userManager.Create(user, userPWD);
            //    if (chkUser.Succeeded)
            //    {
            //        var result1 = userManager.AddToRole(userManager.FindByEmail(user.Email).Id, "Guest")  ;
            //    }
            //}

            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            roleManager.Create(new IdentityRole("Admins"));
            roleManager.Create(new IdentityRole("Guests"));

            if (!(context.Users.Any(u => u.UserName == "Admin@Company.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "Admin@Company.com" };
                userManager.Create(userToInsert, "Password@123");
                userManager.AddToRole(userToInsert.Id, "Admins");
            }

            if (!(context.Users.Any(u => u.UserName == "Admin@Company.com")))
            {
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "Guest@Company.com" };
                userManager.Create(userToInsert, "Password@123");
                userManager.AddToRole(userToInsert.Id, "Guests");
            }
        }
    }
}
