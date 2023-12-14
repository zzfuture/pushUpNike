using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Cliente : BaseEntity
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}
