﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ModelFirstCodeFirst
{
    public class ContextoEmpleados:DbContext
    {
        public ContextoEmpleados() : base("Cadena") { }
        public DbSet<Empleado> empleados { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}