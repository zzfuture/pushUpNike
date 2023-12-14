using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Pago : BaseEntity
{
    public DateOnly? Fechapago { get; set; }

    public int? Total { get; set; }

    public int? IdClienteFk { get; set; }

    public int? IdFormaPagoFk { get; set; }

    public virtual Cliente? IdClienteFkNavigation { get; set; }

    public virtual Formapago? IdFormaPagoFkNavigation { get; set; }
}
