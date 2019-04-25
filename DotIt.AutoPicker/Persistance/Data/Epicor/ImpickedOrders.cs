using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpickedOrders
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string SupplyJobNum { get; set; }
        public string LotNum { get; set; }
        public decimal Quantity { get; set; }
        public string Uom { get; set; }
        public DateTime? ReqDate { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string ShipViaCode { get; set; }
        public string PartNum { get; set; }
        public bool Complete { get; set; }
        public int BtcustNum { get; set; }
        public int BtconNum { get; set; }
        public int ShipToCustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
    }
}
