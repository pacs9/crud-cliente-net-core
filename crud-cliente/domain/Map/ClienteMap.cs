using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace domain.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.DataNascimento).IsRequired();
            builder.Property(c => c.Sexo).IsRequired();
        }
    }
}
