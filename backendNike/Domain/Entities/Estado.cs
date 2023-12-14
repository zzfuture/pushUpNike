using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Estado : BaseEntity
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
