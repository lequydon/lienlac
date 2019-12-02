namespace Ktra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Ktra.model.KtraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Ktra.model.KtraContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                context.lienlacs.AddOrUpdate(new model.lienlac
                {
                    id = "101" + i.ToString(),
                    name = "Don" + i.ToString(),
                    emali = "donle2044" + i.ToString()+"@gmail.com",
                    sdt = "033915988"+i.ToString(),
                    diachi = "quang trị",
                    idnhom = "101"
                });
            }
            for (int i = 0; i < 10; i++)
            {
                context.nhoms.AddOrUpdate(new model.nhom
                {
                    id = "10" + i.ToString(),
                    tennhom = "nhom"+i.ToString()
                });
            }
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
