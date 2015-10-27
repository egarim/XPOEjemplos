using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{

    public class FacturaDetalle : XPObject
    {
        public FacturaDetalle() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public FacturaDetalle(Session session) : base(session)
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
        private decimal _Total;
        private decimal _PrecioUnitario;
        private double _Cantidad;
        private Producto _Producto;
        private Factura _Factura;

        [Association("Factura-FacturaDetalles")]
        public Factura Factura
        {
            get
            {
                return _Factura;
            }
            set
            {
                SetPropertyValue("Factura", ref _Factura, value);
            }
        }

        public Producto Producto
        {
            get
            {
                return _Producto;
            }
            set
            {
                SetPropertyValue("Producto", ref _Producto, value);
            }
        }

        public double Cantidad
        {
            get
            {
                return _Cantidad;
            }
            set
            {
                SetPropertyValue("Cantidad", ref _Cantidad, value);
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

        public decimal Total
        {
            get
            {
                return _Total;
            }
            set
            {
                SetPropertyValue("Total", ref _Total, value);
            }
        }
    }

}