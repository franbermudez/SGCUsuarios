using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SGC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }//fin del constructor

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Niveles> Niveles { get; set; }

    }
}
