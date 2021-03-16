using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ejercicio_codefirst
{
    public class Empdbcontext : DbContext
    {
      public DbSet<Empleado> Empleados{ get; set; }
    }
}
