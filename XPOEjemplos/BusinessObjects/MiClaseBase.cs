using System;
using DevExpress.Xpo;

namespace XPOEjemplos.BusinessObjects
{
    [NonPersistent()]
    public class MiClaseBase : XPObject
    {
        public MiClaseBase() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public MiClaseBase(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
    }

}