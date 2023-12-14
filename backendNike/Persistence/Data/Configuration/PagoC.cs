using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PagoC : IEntityTypeConfiguration<Pago>
    {
        public void Configure(EntityTypeBuilder<Pago> builder)
        {
builder
                .HasNoKey()
                .ToTable("pago");

            builder.HasIndex(e => e.IdClienteFk, "idClienteFk");

            builder.HasIndex(e => e.IdFormaPagoFk, "idFormaPagoFk");

            builder.Property(e => e.Fechapago).HasColumnName("fechapago");
            builder.Property(e => e.IdClienteFk).HasColumnName("idClienteFk");
            builder.Property(e => e.IdFormaPagoFk).HasColumnName("idFormaPagoFk");
            builder.Property(e => e.Total).HasColumnName("total");

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany()
                .HasForeignKey(d => d.IdClienteFk)
                .HasConstraintName("pago_ibfk_1");

            builder.HasOne(d => d.IdFormaPagoFkNavigation).WithMany()
                .HasForeignKey(d => d.IdFormaPagoFk)
                .HasConstraintName("pago_ibfk_2");
        }
    }
}

