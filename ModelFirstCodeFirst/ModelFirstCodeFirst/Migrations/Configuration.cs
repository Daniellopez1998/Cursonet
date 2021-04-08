namespace ModelFirstCodeFirst.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ModelFirstCodeFirst;



    internal sealed class Configuration : DbMigrationsConfiguration<ModelFirstCodeFirst.ContextoEmpleados>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ModelFirstCodeFirst.ContextoEmpleados context)
        {
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
            context.empleados.AddOrUpdate(z => z.Nombre,
            new Empleado
            {
                IdEmpleado = 1,
                Nombre = "David",
                Apellidos = "Fernández Huertas",
                Direccion = "Calle Atlético de Madrid",
                Email = "david@mail.com"
            },
            new Empleado
            {
                IdEmpleado = 2,
                Nombre = "Daniel",
                Apellidos = "Hernández Cavanillos",
                Direccion = "Calle Portugal",
                Email = "Daniel@mail.com"
            },
             new Empleado
             {
                 IdEmpleado = 3,
                 Nombre = "Ana",
                 Apellidos = "Rodrírguez López",
                 Direccion = "Calle Atlético de Madrid",
                 Email = "Ana@mail.com"
             }
             );


        }
    }
}
