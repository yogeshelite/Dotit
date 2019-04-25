using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imrmarcpt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Rmanum { get; set; }
        public int Rmaline { get; set; }
        public int Rmareceipt { get; set; }
        public string WareHouseCode { get; set; }
        public string BinNum { get; set; }
        public DateTime? RcvDate { get; set; }
        public string LotNum { get; set; }
        public bool OpenReceipt { get; set; }
        public decimal MtlUnitCost { get; set; }
        public decimal LbrUnitCost { get; set; }
        public decimal BurUnitCost { get; set; }
        public decimal SubUnitCost { get; set; }
        public decimal MtlBurUnitCost { get; set; }
        public string Plant { get; set; }
        public decimal MtlMtlUnitCost { get; set; }
        public decimal MtlLabUnitCost { get; set; }
        public decimal MtlSubUnitCost { get; set; }
        public decimal MtlBurdenUnitCost { get; set; }
        public decimal MtlMtlBurUnitCost { get; set; }
        public decimal ReceivedQty { get; set; }
        public decimal DisposedQty { get; set; }
        public string CostUom { get; set; }
        public string ReceivedQtyUom { get; set; }
        public string LegalNumber { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public bool RequestMove { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
