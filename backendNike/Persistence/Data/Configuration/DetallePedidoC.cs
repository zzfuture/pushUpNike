using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DetallepedidoC : IEntityTypeConfiguration<Detallepedido>
    {
        public void Configure(EntityTypeBuilder<Detallepedido> builder)
        {
builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("detallepedido");

            builder.HasIndex(e => e.IdPedidoFk, "idPedidoFk");

            builder.HasIndex(e => e.IdProductoFk, "idProductoFk");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.IdPedidoFk).HasColumnName("idPedidoFk");
            builder.Property(e => e.IdProductoFk).HasColumnName("idProductoFk");
            builder.Property(e => e.Precio).HasColumnName("precio");

            builder.HasOne(d => d.IdPedidoFkNavigation).WithMany(p => p.Detallepedidos)
                .HasForeignKey(d => d.IdPedidoFk)
                .HasConstraintName("detallepedido_ibfk_1");

            builder.HasOne(d => d.IdProductoFkNavigation).WithMany(p => p.Detallepedidos)
                .HasForeignKey(d => d.IdProductoFk)
                .HasConstraintName("detallepedido_ibfk_2");
        }
    }
}

