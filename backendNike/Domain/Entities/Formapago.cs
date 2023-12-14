using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Formapago : BaseEntity
{
    public int Id { get; set; }

    public string? Nombre { get; set; }
}
