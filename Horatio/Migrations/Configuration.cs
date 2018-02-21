namespace Horatio.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Horatio.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Horatio.Models.ApplicationDbContext context)
        {
            context.ETAs.AddOrUpdate(x => x.TIME,
                new ETA() { ETA_ID = 1, TIME = "1 Hour" },
                new ETA() { ETA_ID = 2, TIME = "3 Hours" },
                new ETA() { ETA_ID = 3, TIME = "1 Day" },
                new ETA() { ETA_ID = 4, TIME = "3 Days" },
                new ETA() { ETA_ID = 5, TIME = "1 Week" },
                new ETA() { ETA_ID = 6, TIME = "2 Weeks" },
                new ETA() { ETA_ID = 7, TIME = "1 Month" },
                new ETA() { ETA_ID = 8, TIME = "3 Months" },
                new ETA() { ETA_ID = 9, TIME = "6 Months" },
                new ETA() { ETA_ID = 10, TIME = "1 Year" },
                new ETA() { ETA_ID = 11, TIME = "As long as it takes" }
                            );

            //  This method will be called after migrating to the latest version.

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
        }
    }
}
