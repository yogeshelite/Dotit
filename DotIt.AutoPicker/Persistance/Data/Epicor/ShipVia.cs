using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShipVia
    {
        public ShipVia()
        {
            EccextShipVia = new HashSet<EccextShipVia>();
        }

        public string Company { get; set; }
        public string ShipViaCode { get; set; }
        public string Description { get; set; }
        public string IstatCode { get; set; }
        public bool RequiresBorder { get; set; }
        public string TrackingUrl { get; set; }
        public string TrackingNumPlaceHolder { get; set; }
        public string WebDesc { get; set; }
        public string Carrier { get; set; }
        public string Scac { get; set; }
        public bool GlobalShipVia { get; set; }
        public bool GlobalLock { get; set; }
        public string Wiapplication { get; set; }
        public string WebShipVia { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string AgafipresponsibilityCode { get; set; }
        public string AgiddocTypeCode { get; set; }
        public string AgiddocumentNumber { get; set; }
        public string Agapartment { get; set; }
        public string AgextraStreetNumber { get; set; }
        public string Agfloor { get; set; }
        public string AglocationCode { get; set; }
        public string Agneighborhood { get; set; }
        public string AgprovinceCode { get; set; }
        public string Agstreet { get; set; }
        public string AgstreetNumber { get; set; }

        public virtual ICollection<EccextShipVia> EccextShipVia { get; set; }
    }
}
