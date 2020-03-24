using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsultasWeb.Models;

namespace ConsultasWeb.Data
{
    public class ClinicContext : DbContext
    {
        public ClinicContext (DbContextOptions<ClinicContext> options)
            : base(options)
        {
        }

        public DbSet<ConsultasWeb.Models.Pacient> Pacient { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pacient>().ToTable("Pacient");
        }
    }
}
