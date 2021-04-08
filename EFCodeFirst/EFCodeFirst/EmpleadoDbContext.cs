using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFCodeFirst
{
    public class EmpleadoDbContext: DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}
