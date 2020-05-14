namespace PrivateParking.Migrations
{
    using PrivateParking.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrivateParking.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PrivateParking.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Customer.Add(new Customer { FirstName = "Ahmad", LastName = "Yassin" });
            context.Customer.Add(new Customer { FirstName = "Osama", LastName = "Zidan" });
            context.Customer.Add(new Customer { FirstName = "Yasmin", LastName = "Khalaili" });
            context.Customer.Add(new Customer { FirstName = "Maen", LastName = "Jomaa" });

                //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
