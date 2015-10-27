using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{

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