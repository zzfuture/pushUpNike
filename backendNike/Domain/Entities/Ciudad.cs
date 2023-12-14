using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Ciudad : BaseEntity
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int IdDepartamentoFk { get; set; }

    public virtual ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();

    public virtual Departamento IdDepartamentoFkNavigation { get; set; } = null!;
}
