using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProductoDto
    {
    public int Id { get; set; }

    public int? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? Cantidadmin { get; set; }

    public int? Cantidadmax { get; set; }

    public int? IdTipoProducto { get; set; }
    }
}