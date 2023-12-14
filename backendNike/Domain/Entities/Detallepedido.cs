using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Detallepedido : BaseEntity
{
    public int Id { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public int? IdPedidoFk { get; set; }

    public int? IdProductoFk { get; set; }

    public virtual Pedido? IdPedidoFkNavigation { get; set; }

    public virtual Producto? IdProductoFkNavigation { get; set; }
}
