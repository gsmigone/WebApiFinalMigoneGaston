using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFinalMigoneGaston.Entidades;

namespace WebApiFinalMigoneGaston.Context
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
    }
}
