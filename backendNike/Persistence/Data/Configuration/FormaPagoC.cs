using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FormapagoC : IEntityTypeConfiguration<Formapago>
    {
        public void Configure(EntityTypeBuilder<Formapago> builder)
        {
 builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("formapago");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Nombre)
                .HasMaxLength(100)
                .HasColumnName("nombre");
        }
    }
}

