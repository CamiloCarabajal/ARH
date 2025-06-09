using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        private readonly bool isTestingEnvironment;
        public DbSet<User> Users { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Club> Clubes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, bool isTestingEnvironment = false) : base(options)
        {
            this.isTestingEnvironment = isTestingEnvironment;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de relaciones
            modelBuilder.Entity<Jugador>()  // Jugador // Partido
                .HasMany(j => j.PartidosList)
                .WithMany(p => p.JugadorList);

            base.OnModelCreating(modelBuilder);
        }
    }
}
