using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Empleado : BaseEntity
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public int? IdCiudadFk { get; set; }

    public virtual Ciudad? IdCiudadFkNavigation { get; set; }
}
