using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsupplierEdi
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public bool Test { get; set; }
        public string EdidocIn { get; set; }
        public string EdidocOut { get; set; }
        public bool UseCustDefault { get; set; }
        public bool UsePriceList { get; set; }
        public bool UseCustPart { get; set; }
        public string MapId { get; set; }
        public bool PrintInv { get; set; }
        public bool UseDftShipTo { get; set; }
        public bool AutoPost { get; set; }
        public bool HoldOrders { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
