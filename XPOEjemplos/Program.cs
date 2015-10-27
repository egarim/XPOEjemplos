using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XPOEjemplos.BusinessObjects;

namespace XPOEjemplos
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private void CrearDatos()
        {
            //Creando Clientes
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Jose Manuel Ojeda", "Santa Elena", "503 321456698", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Oscar Ojeda", "Santa Elena", "503 231458967", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Jaime Macias", "San Miguel", "503 258963147", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Juan Perez", "Santa Ana", "503 23654789", true);
        }
        private void CrearCliente(Session Session,string Nombre,string Direccion,string Telefono,bool Activo)
        {
            Cliente Cliente = new Cliente(Session);
            Cliente.Nombre = Nombre;
            Cliente.Direccion = Direccion;
            Cliente.Telefono = Telefono;
            Cliente.Activo = Activo;
            Cliente.Save();
        }
        private void CrearCliente(UnitOfWork UoW, string Nombre, string Direccion, string Telefono, bool Activo)
        {
            Cliente Cliente = new Cliente(UoW);
            Cliente.Nombre = Nombre;
            Cliente.Direccion = Direccion;
            Cliente.Telefono = Telefono;
            Cliente.Activo = Activo;
            
        }
        private void CrearProductos(Session Session, string Descripcion, string Nombre, decimal PrecioUnitario, double CantidadEnInventario)
        {
            Producto Producto = new Producto(Session);
            Producto.Nombre = Nombre;
            Producto.Descripcion = Descripcion;
            Producto.PrecioUnitario = PrecioUnitario;
            Producto.CantidadEnInventario = CantidadEnInventario;

        }
    }
}
