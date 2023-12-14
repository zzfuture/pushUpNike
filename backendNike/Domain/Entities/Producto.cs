using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Producto : BaseEntity
{
    public int Id { get; set; }

    public int? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? Cantidadmin { get; set; }

    public int? Cantidadmax { get; set; }

    public int? IdTipoProducto { get; set; }

    public virtual ICollection<Detallepedido> Detallepedidos { get; set; } = new List<Detallepedido>();

    public virtual Tipoproducto? IdTipoProductoNavigation { get; set; }
}
