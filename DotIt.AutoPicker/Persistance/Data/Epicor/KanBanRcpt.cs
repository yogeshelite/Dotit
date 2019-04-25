using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class KanBanRcpt
    {
        public string Company { get; set; }
        public string ReceiptId { get; set; }
        public string PartNum { get; set; }
        public string LotNum { get; set; }
        public string LegalNumber { get; set; }
        public string ScrapReason { get; set; }
        public string NonConfReason { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public string BinNum { get; set; }
        public string EmpId { get; set; }
        public string Ium { get; set; }
        public string Iumdisp { get; set; }
        public string WarehouseCode { get; set; }
        public string JobNum { get; set; }
        public bool TrackLots { get; set; }
        public bool TrackSerialNum { get; set; }
        public bool UseJobNumForLot { get; set; }
        public bool JobEngineered { get; set; }
        public bool JobFirm { get; set; }
        public bool JobReleased { get; set; }
        public bool DisableAltMethod { get; set; }
        public bool CanReportNcqty { get; set; }
        public bool CanReportScrapQty { get; set; }
        public decimal NonConfQuantity { get; set; }
        public decimal Quantity { get; set; }
        public decimal ScrapQuantity { get; set; }
        public decimal Snquantity { get; set; }
        public DateTime? JobDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
