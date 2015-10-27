using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{

    public class Producto : XPObject
    {
        public Producto() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Producto(Session session) : base(session)
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
        private double _CantidadEnInventario;
        private decimal _PrecioUnitario;
        private bool _Activo;
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
        // Fields...
        private string _Descripcion;

        [Size(300)]
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                SetPropertyValue("Descripcion", ref _Descripcion, value);
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

        public decimal PrecioUnitario
        {
            get
            {
                return _PrecioUnitario;
            }
            set
            {
                SetPropertyValue("PrecioUnitario", ref _PrecioUnitario, value);
            }
        }

        public double CantidadEnInventario
        {
            get
            {
                return _CantidadEnInventario;
            }
            set
            {
                SetPropertyValue("CantidadEnInventario", ref _CantidadEnInventario, value);
            }
        }
    }

}