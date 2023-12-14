using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICiudad Ciudades { get; } // 2611
        public ICliente Clientes { get; }
        public IDetallePedidos DetallePedidos { get; }
        public IEmpleado Empleados { get; }
        public IEstado Estados { get; }
        public IFormaPago Formapagos { get; }
        public ITipoProducto TipoProductos { get; }
        public IPago Pagos { get; }
        public IPais Paises { get; }
        public IPedido Pedidos { get; }
        public IProducto Productos { get; }
        public IUser Users { get; }
        public IRol Rols { get; }
        
        Task<int> SaveAsync(); // 2611
    }
}