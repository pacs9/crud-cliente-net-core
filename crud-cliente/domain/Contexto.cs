using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    public class Contexto : DbContext
    {
        public Contexto()
           : base()
        { }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("string de conexão");
            }
        }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Database.SetInitializer<UsuarioContexto>(new CreateDatabaseIfNotExists<UsuarioContexto>());
        }
        
        
        public DbSet<Cliente> Clientes { get; set; }
    }
}
