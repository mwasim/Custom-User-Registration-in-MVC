using Microsoft.AspNet.Identity.EntityFramework;
using MVCRegistrationDemo.Helpers;

namespace MVCRegistrationDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCRegistrationDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MVCRegistrationDemo.Models.ApplicationDbContext context)
        {
            // This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            //Add default user roles
            context.Roles.AddOrUpdate(new IdentityRole(Constants.UserType.Buyer));
            context.Roles.AddOrUpdate(new IdentityRole(Constants.UserType.Seller));
        }
    }
}
