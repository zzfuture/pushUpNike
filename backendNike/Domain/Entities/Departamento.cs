﻿using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Departamento : BaseEntity
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int IdPaisFk { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Pais IdPaisFkNavigation { get; set; } = null!;
}
