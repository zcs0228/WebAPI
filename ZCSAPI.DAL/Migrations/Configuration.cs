namespace ZCSAPI.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZCSAPI.DAL.APIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ZCSAPI.DAL.APIContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Users.AddOrUpdate(new DBModels.User
            {
                ID = Guid.NewGuid(),
                Code = "zcs",
                Name = "Admin",
                Password = "dd09bf074cbed0d125c818421e3c77579d6c5b226e3722f0288674e09a46dc4d",
                PasswordSalt = "0809101112131415"
            });
        }
    }
}
