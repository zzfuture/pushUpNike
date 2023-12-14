using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Pedido : BaseEntity
{
    public int Id { get; set; }

    public string? Comentario { get; set; }

    public int? IdClienteFk { get; set; }

    public int? IdEstadoFk { get; set; }

    public virtual ICollection<Detallepedido> Detallepedidos { get; set; } = new List<Detallepedido>();

    public virtual Cliente? IdClienteFkNavigation { get; set; }

    public virtual Estado? IdEstadoFkNavigation { get; set; }
}
