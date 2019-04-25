using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImshipDtlInfo
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int PackNum { get; set; }
        public int PackLine { get; set; }
        public long PackLineSeq { get; set; }
        public decimal OurInventoryShipQty { get; set; }
        public decimal OurJobShipQty { get; set; }
        public decimal SellingInventoryShipQty { get; set; }
        public decimal SellingJobShipQty { get; set; }
        public decimal PickedAutoAllocatedQty { get; set; }
        public decimal NotAllocatedQty { get; set; }
        public string Ium { get; set; }
        public string SalesUm { get; set; }
        public string InventoryShipUom { get; set; }
        public string JobShipUom { get; set; }
        public string Pcid { get; set; }
        public long PciditemSeq { get; set; }
        public int PcidparentLine { get; set; }
        public string LotNum { get; set; }
        public string JobLotNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
