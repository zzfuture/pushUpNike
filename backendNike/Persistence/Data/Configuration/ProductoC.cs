using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProductoC : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("producto");

            builder.HasIndex(e => e.IdTipoProducto, "idTipoProducto");

            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Cantidad).HasColumnName("cantidad");
            builder.Property(e => e.Cantidadmax).HasColumnName("cantidadmax");
            builder.Property(e => e.Cantidadmin).HasColumnName("cantidadmin");
            builder.Property(e => e.IdTipoProducto).HasColumnName("idTipoProducto");
            builder.Property(e => e.Precio).HasColumnName("precio");

            builder.HasOne(d => d.IdTipoProductoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdTipoProducto)
                .HasConstraintName("producto_ibfk_1");
        }
    }
}

