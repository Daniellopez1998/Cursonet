using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CodeFirst2.Models
{
    public class ContextoEmpleados:DbContext
    {
        public ContextoEmpleados() : base("Cadena") { }
        public DbSet<Empleado> Empleados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}