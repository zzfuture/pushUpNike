using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly NikeContext _context;

        public UnitOfWork(NikeContext context) // 2611
        {
        _context = context;
        }


        private ICiudad _Ciudades;
private IDepartamento _Departamentos;
private ICliente _Clientes;
private IDetallePedidos _DetallePedidos;
private IEmpleado _Empleados;
private IEstado _Estados;
private IFormaPago _Formapagos;
private IPago _Pagos;
private IPais _Paises;
private IPedido _Pedidos;
private IProducto _Productos;
private IRol _Rols;
private ITipoProducto _TipoProductos;
private IUser _Users;

        public ICiudad Ciudades // 2611
        {
            get
            {
                if (_Ciudades == null)
                {
                    _Ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Ciudades;
            }
        }public IDepartamento Departamentos // 2611
        {
            get
            {
                if (_Departamentos == null)
                {
                    _Departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Departamentos;
            }
        }
        public ICliente Clientes // 2611
        {
            get
            {
                if (_Clientes == null)
                {
                    _Clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
                }
                return _Clientes;
            }
        }
        public IDetallePedidos DetallePedidos 
{
    get
    {
        if (_DetallePedidos == null)
        {
            _DetallePedidos = new DetallePedidoRepository(_context);
        }
        return _DetallePedidos;
    }
}

public IEmpleado Empleados 
{
    get
    {
        if (_Empleados == null)
        {
            _Empleados = new EmpleadoRepository(_context);
        }
        return _Empleados;
    }
}

public IEstado Estados 
{
    get
    {
        if (_Estados == null)
        {
            _Estados = new EstadoRepository(_context);
        }
        return _Estados;
    }
}

public IFormaPago Formapagos
{
    get
    {
        if (_Formapagos == null)
        {
            _Formapagos = new FormaPagoRepository(_context);
        }
        return _Formapagos;
    }
}

public IPago Pagos 
{
    get
    {
        if (_Pagos == null)
        {
            _Pagos = new PagoRepository(_context);
        }
        return _Pagos;
    }
}

public IPais Paises 
{
    get
    {
        if (_Paises == null)
        {
            _Paises = new PaisRepository(_context);
        }
        return _Paises;
    }
}

public IPedido Pedidos 
{
    get
    {
        if (_Pedidos == null)
        {
            _Pedidos = new PedidoRepository(_context);
        }
        return _Pedidos;
    }
}

public IProducto Productos 
{
    get
    {
        if (_Productos == null)
        {
            _Productos = new ProductoRepository(_context);
        }
        return _Productos;
    }
}

public IRol Rols 
{
    get
    {
        if (_Rols == null)
        {
            _Rols = new RolRepository(_context);
        }
        return _Rols;
    }
}

public ITipoProducto TipoProductos 
{
    get
    {
        if (_TipoProductos == null)
        {
            _TipoProductos = new TipoProductoRepository(_context);
        }
        return _TipoProductos;
    }
}

public IUser Users 
{
    get
    {
        if (_Users == null)
        {
            _Users = new UserRepository(_context);
        }
        return _Users;
    }
}

public Task<int> SaveAsync() // 2611
{
    return _context.SaveChangesAsync();
}
}
}