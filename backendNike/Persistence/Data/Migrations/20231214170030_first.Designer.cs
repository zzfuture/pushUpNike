﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(NikeContext))]
    [Migration("20231214170030_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int")
                        .HasColumnName("idDepartamentoFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique();

                    b.HasIndex(new[] { "IdDepartamentoFk" }, "idDepartamentoFk");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique();

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id1");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int")
                        .HasColumnName("idPaisFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id2");

                    b.HasIndex(new[] { "IdPaisFk" }, "idPaisFk");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique()
                        .HasDatabaseName("nombre1");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detallepedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("IdPedidoFk")
                        .HasColumnType("int")
                        .HasColumnName("idPedidoFk");

                    b.Property<int?>("IdProductoFk")
                        .HasColumnType("int")
                        .HasColumnName("idProductoFk");

                    b.Property<int?>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdPedidoFk" }, "idPedidoFk");

                    b.HasIndex(new[] { "IdProductoFk" }, "idProductoFk");

                    b.ToTable("detallepedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Apellido")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("apellido");

                    b.Property<int?>("IdCiudadFk")
                        .HasColumnType("int")
                        .HasColumnName("idCiudadFk");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<string>("Telefono")
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("telefono");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id3");

                    b.HasIndex(new[] { "IdCiudadFk" }, "idCiudadFk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id4");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Formapago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("formapago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.Property<DateOnly?>("Fechapago")
                        .HasColumnType("date")
                        .HasColumnName("fechapago");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.Property<int?>("IdFormaPagoFk")
                        .HasColumnType("int")
                        .HasColumnName("idFormaPagoFk");

                    b.Property<int?>("Total")
                        .HasColumnType("int")
                        .HasColumnName("total");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFk");

                    b.HasIndex(new[] { "IdFormaPagoFk" }, "idFormaPagoFk");

                    b.ToTable("pago", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Id" }, "id")
                        .IsUnique()
                        .HasDatabaseName("id5");

                    b.HasIndex(new[] { "Nombre" }, "nombre")
                        .IsUnique()
                        .HasDatabaseName("nombre2");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Comentario")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("comentario");

                    b.Property<int?>("IdClienteFk")
                        .HasColumnType("int")
                        .HasColumnName("idClienteFk");

                    b.Property<int?>("IdEstadoFk")
                        .HasColumnType("int")
                        .HasColumnName("idEstadoFk");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdClienteFk" }, "idClienteFk");

                    b.HasIndex(new[] { "IdEstadoFk" }, "idEstadoFk");

                    b.ToTable("pedido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<int?>("Cantidadmax")
                        .HasColumnType("int")
                        .HasColumnName("cantidadmax");

                    b.Property<int?>("Cantidadmin")
                        .HasColumnType("int")
                        .HasColumnName("cantidadmin");

                    b.Property<int?>("IdTipoProducto")
                        .HasColumnType("int")
                        .HasColumnName("idTipoProducto");

                    b.Property<int?>("Precio")
                        .HasColumnType("int")
                        .HasColumnName("precio");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdTipoProducto" }, "idTipoProducto");

                    b.ToTable("producto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Tipoproducto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Nombre")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("tipoproducto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("TokenCreated")
                        .HasColumnType("date");

                    b.Property<DateTime>("TokenExpires")
                        .HasColumnType("date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRolFk")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdRolFk");

                    b.HasIndex("IdRolFk");

                    b.ToTable("userrol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "IdDepartamentoFkNavigation")
                        .WithMany("Ciudads")
                        .HasForeignKey("IdDepartamentoFk")
                        .IsRequired()
                        .HasConstraintName("ciudad_ibfk_1");

                    b.Navigation("IdDepartamentoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "IdPaisFkNavigation")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .IsRequired()
                        .HasConstraintName("departamento_ibfk_1");

                    b.Navigation("IdPaisFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Detallepedido", b =>
                {
                    b.HasOne("Domain.Entities.Pedido", "IdPedidoFkNavigation")
                        .WithMany("Detallepedidos")
                        .HasForeignKey("IdPedidoFk")
                        .HasConstraintName("detallepedido_ibfk_1");

                    b.HasOne("Domain.Entities.Producto", "IdProductoFkNavigation")
                        .WithMany("Detallepedidos")
                        .HasForeignKey("IdProductoFk")
                        .HasConstraintName("detallepedido_ibfk_2");

                    b.Navigation("IdPedidoFkNavigation");

                    b.Navigation("IdProductoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "IdCiudadFkNavigation")
                        .WithMany("Empleados")
                        .HasForeignKey("IdCiudadFk")
                        .HasConstraintName("empleado_ibfk_1");

                    b.Navigation("IdCiudadFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pago", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany()
                        .HasForeignKey("IdClienteFk")
                        .HasConstraintName("pago_ibfk_1");

                    b.HasOne("Domain.Entities.Formapago", "IdFormaPagoFkNavigation")
                        .WithMany()
                        .HasForeignKey("IdFormaPagoFk")
                        .HasConstraintName("pago_ibfk_2");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdFormaPagoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "IdClienteFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdClienteFk")
                        .HasConstraintName("pedido_ibfk_1");

                    b.HasOne("Domain.Entities.Estado", "IdEstadoFkNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdEstadoFk")
                        .HasConstraintName("pedido_ibfk_2");

                    b.Navigation("IdClienteFkNavigation");

                    b.Navigation("IdEstadoFkNavigation");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.Tipoproducto", "IdTipoProductoNavigation")
                        .WithMany("Productos")
                        .HasForeignKey("IdTipoProducto")
                        .HasConstraintName("producto_ibfk_1");

                    b.Navigation("IdTipoProductoNavigation");
                });

            modelBuilder.Entity("Domain.Entities.UserRol", b =>
                {
                    b.HasOne("Domain.Entities.Rol", "Rols")
                        .WithMany("UserRols")
                        .HasForeignKey("IdRolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "Users")
                        .WithMany("UserRols")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rols");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudads");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Pedido", b =>
                {
                    b.Navigation("Detallepedidos");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Navigation("Detallepedidos");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("UserRols");
                });

            modelBuilder.Entity("Domain.Entities.Tipoproducto", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("UserRols");
                });
#pragma warning restore 612, 618
        }
    }
}