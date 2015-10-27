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
            //Creando productios
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Microsoft Surface", "Table hibrida", 900, 500);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Macbook pro", "laptop de apple", 1200, 700);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Arduino Uno", "Micro controlador italiando", 230, 800);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Microsoft Surface", "Table hibrida", 600, 890);
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
        private void CrearProducto(Session Session,  string Nombre, string Descripcion, decimal PrecioUnitario, double CantidadEnInventario)
        {
            Producto Producto = new Producto(Session);
            Producto.Nombre = Nombre;
            Producto.Descripcion = Descripcion;
            Producto.PrecioUnitario = PrecioUnitario;
            Producto.CantidadEnInventario = CantidadEnInventario;
            Producto.Save();

        }
    }
}
