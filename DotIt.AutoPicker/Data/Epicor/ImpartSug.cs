using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartSug
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Classifier { get; set; }
        public bool NewFlag { get; set; }
        public string Type { get; set; }
        public string SubType { get; set; }
        public string PartNum { get; set; }
        public string TargetJobNum { get; set; }
        public int TargetAssemblySeq { get; set; }
        public int TargetMtlSeq { get; set; }
        public string Source { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public string JobSeqType { get; set; }
        public int JobSeq { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string WarehouseCode { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? SugDate { get; set; }
        public decimal SugQty { get; set; }
        public string SugQtyUom { get; set; }
        public string SugRevisionNum { get; set; }
        public string Description { get; set; }
        public string CustShortName { get; set; }
        public string CustId { get; set; }
        public int Ponum { get; set; }
        public int Poline { get; set; }
        public int PorelNum { get; set; }
        public string PlannerId { get; set; }
        public bool FirmRelease { get; set; }
        public bool StockTrans { get; set; }
        public string Plant { get; set; }
        public int SugNum { get; set; }
        public string TflineNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ContractId { get; set; }
    }
}
