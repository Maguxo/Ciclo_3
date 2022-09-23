using System;
using Microsoft.EntityFrameworkCore;
using HomePetCare.App.Dominio;

/// conexión con la base de datos
namespace HomePetCare.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<EstadoVital> EstadoVitales { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Ser> seres { get; set; }
        public DbSet<Veterinary> Veterinarys { get; set; }
        public DbSet<Visit> Visits { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =HomePetCare.DataBase"); 
                              
            }

        }
    }
}