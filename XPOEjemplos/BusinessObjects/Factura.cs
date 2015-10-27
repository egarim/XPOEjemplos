using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{

    public class Factura : XPObject
    {
        public Factura() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Factura(Session session) : base(session)
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
        private DateTime _FechaDeVencimiento;
        private string _Telefono;
        private string _Direccion;
        private Cliente _Cliente;
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                SetPropertyValue("Fecha", ref _Fecha, value);
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _Cliente;
            }
            set
            {
                SetPropertyValue("Cliente", ref _Cliente, value);
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

        public DateTime FechaDeVencimiento
        {
            get
            {
                return _FechaDeVencimiento;
            }
            set
            {
                SetPropertyValue("FechaDeVencimiento", ref _FechaDeVencimiento, value);
            }
        }
      
        [DevExpress.Xpo.Aggregated()]
        [Association("Factura-FacturaDetalles")]
        public XPCollection<Factura> FacturaDetalles
        {
            get
            {
                return GetCollection<Factura>("FacturaDetalles");
            }
        }
    }

}