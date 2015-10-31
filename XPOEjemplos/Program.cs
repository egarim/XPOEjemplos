using DevExpress.Xpo;
using DevExpress.Xpo.DB;
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
            //las mejores practicas de XPO
            //https://www.devexpress.com/Support/Center/Question/Details/A2944
            ConxionBaseDeDatos();
            CrearDatos();
        }
        private static void ConxionBaseDeDatos()
        {
            //Bases de datos soportadas
            //https://documentation.devexpress.com/#CoreLibraries/CustomDocument2114

            //Ejemplos de conexion para todas las bases de XPO
            //https://www.devexpress.com/Support/Center/Question/Details/K18445



            //Conexion a access, el provedor esta en el namspace DevExpress.Xpo.DB, alli estan los demas proveedores, como OracleConnectionProvider o MSSqlConnectionProvider
            //estos proveedores son clases estaticas que tiene un metodo para crear la cadena de conexion, esta cadena tambien se puede crear a mano segun los ejemplos de el link
            //https://www.devexpress.com/Support/Center/Question/Details/K18445 o con la clase estatica segun los ejemplos de este link
            https://documentation.devexpress.com/#CoreLibraries/CustomDocument3243


            //TODO quitar el comentario para usar access o mysql

            //Access
            //string conn = AccessConnectionProvider.GetConnectionString(@"EjemplosXPO.mdb");

            //MySQL
            string conn = MySqlConnectionProvider.GetConnectionString("localhost", "root", "JoseManuel16", "EjemplosXPO");


            //TIP # 3. Explicitly set the XpoDefault.DataLayer property in the entry point of your application. 
            //https://www.devexpress.com/Support/Center/Question/Details/A2944
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema);
        }

        private static void CrearDatos()
        {
            //Creando Clientes
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Jose Manuel Ojeda", "Santa Elena", "503 321456698", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Oscar Ojeda", "Santa Elena", "503 231458967", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Jaime Macias", "San Miguel", "503 258963147", true);
            CrearCliente(DevExpress.Xpo.XpoDefault.Session, "Juan Perez", "Santa Ana", "503 23654789", true);
            //Creando productos
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Microsoft Surface", "Table hibrida", 900, 500);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Macbook pro", "laptop de apple", 1200, 700);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Arduino Uno", "Micro controlador Italiano", 230, 800);
            CrearProducto(DevExpress.Xpo.XpoDefault.Session, "Microsoft Surface", "Table hibrida", 600, 890);
        }
        private static void CrearCliente(Session Session,string Nombre,string Direccion,string Telefono,bool Activo)
        {
            Cliente Cliente = new Cliente(Session);
            Cliente.Nombre = Nombre;
            Cliente.Direccion = Direccion;
            Cliente.Telefono = Telefono;
            Cliente.Activo = Activo;
            Cliente.Save();
        }
        private static void CrearCliente(UnitOfWork UoW, string Nombre, string Direccion, string Telefono, bool Activo)
        {
            Cliente Cliente = new Cliente(UoW);
            Cliente.Nombre = Nombre;
            Cliente.Direccion = Direccion;
            Cliente.Telefono = Telefono;
            Cliente.Activo = Activo;
            
        }
        private static void CrearProducto(Session Session,  string Nombre, string Descripcion, decimal PrecioUnitario, double CantidadEnInventario)
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
