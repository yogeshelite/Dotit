using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbPartClass
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool AvailForReq { get; set; }
        public string BuyerId { get; set; }
        public string ClassId { get; set; }
        public string CommodityCode { get; set; }
        public string Company { get; set; }
        public bool ConsolidatedPurchasing { get; set; }
        public string Description { get; set; }
        public decimal MtlBurRate { get; set; }
        public string NegQtyAction { get; set; }
        public string PurchCode { get; set; }
        public bool RcvInspectionReq { get; set; }
        public bool SplitPoline { get; set; }
        public string GlbCompany { get; set; }
        public string GlbClassId { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPartClass { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Mmsinclude { get; set; }
        public bool Mmssales { get; set; }
        public bool Mmsissue { get; set; }
        public int Mmshistory { get; set; }
        public int MmssafetyFactor { get; set; }
        public decimal MmsmaxFactor { get; set; }
        public int PartLeadTime { get; set; }
        public bool Lcnrvreporting { get; set; }
    }
}
