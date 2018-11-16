using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class Prueba_API_Context :DbContext
    {
        public Prueba_API_Context(DbContextOptions<Prueba_API_Context> options) : base(options)
        {

        }
        public DbSet<Personas> Personas { get; set; }
    }
}
