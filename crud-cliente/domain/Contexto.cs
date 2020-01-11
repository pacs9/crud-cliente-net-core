using domain.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
           : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("ConnectionString:MySqlConnectionString");
            }
        }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Cliente>(new ClienteMap().Configure);            
            //Database.SetInitializer<Contexto>(new CreateDatabaseIfNotExists<Contexto>())

        }
        
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
