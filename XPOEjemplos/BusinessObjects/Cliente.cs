using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{

    /*
    Tipos de datos soportados en xpo
        https://documentation.devexpress.com/#CoreLibraries/CustomDocument2003
    Como y por que XPO extiende el esquema creado en la base de datos
       
    -aqui se explica por que se crean las columnas, en todas las tablas:
        OptimisticLockField 
        GCRecord
        Oid
    -Control de concurrencia
        https://documentation.devexpress.com/#CoreLibraries/CustomDocument2106

    -Como procede XPO con las clases polimorficas (Caso de herencia)
        https://documentation.devexpress.com/#CoreLibraries/CustomDocument2632

    -Borrado logico o retardado, este esta implentado por default y aqui se explica como esta implementado
        https://documentation.devexpress.com/#CoreLibraries/CustomDocument2103

    -CodeRush templates para crear clases persistentes con shorcuts en el teclado
        https://documentation.devexpress.com/#CodeRush/CustomDocument9279

    -Como se refleja del herencia de clases en las tablas
        https://documentation.devexpress.com/#CoreLibraries/CustomDocument2125

    TIP 2. por que usar el setter especial SetPropertyValue
        https://www.devexpress.com/Support/Center/Question/Details/A2944
    
    Como cargar todos los obejetos relacionados en un solo query en vez de un query por objeto
    https://documentation.devexpress.com/#CoreLibraries/clsDevExpressXpoExplicitLoadingAttributetopic

    Listado de atributos de XPO
    https://documentation.devexpress.com/#CoreLibraries/CustomDocument2005


    Esta documentacion no dice nada importante pero este metodo se puede invocar haciendo override al
    onloaded para cargar los detalles en un solo query en vez de un query por cada linea de detalle
   https://documentation.devexpress.com/#CoreLibraries/DevExpressXpoSession_PreFetch[T]topic

    */
    public class Cliente : XPObject
    {
        public Cliente() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Cliente(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        // Fields...
        private bool _Activo;
        private string _Telefono;
        private string _Direccion;
        private string _Nombre;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                SetPropertyValue("Nombre", ref _Nombre, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                SetPropertyValue("Direccion", ref _Direccion, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                SetPropertyValue("Telefono", ref _Telefono, value);
            }
        }

        public bool Activo
        {
            get
            {
                return _Activo;
            }
            set
            {
                SetPropertyValue("Activo", ref _Activo, value);
            }
        }

    }

}