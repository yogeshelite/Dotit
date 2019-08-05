using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpurMisc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public string TaxCatId { get; set; }
        public string Ischarge { get; set; }
        public bool Lcflag { get; set; }
        public decimal Lcamount { get; set; }
        public string LcdisburseMethod { get; set; }
        public string LccurrencyCode { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool EmpExpenseFlag { get; set; }
        public bool ExpCommentRequired { get; set; }
        public string ExpCommentText { get; set; }
        public bool ExpUnitBased { get; set; }
        public bool ExpChargeable { get; set; }
        public int ExpPmuid { get; set; }
        public bool ExpIndirect { get; set; }
        public string ExpTaxRegionCode { get; set; }
        public bool ExpProject { get; set; }
        public string ExpDescription { get; set; }
        public bool GlobalPurMisc { get; set; }
        public bool GlobalLock { get; set; }
        public bool ExpAdvanceRequest { get; set; }
        public bool ExpJob { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Inactive { get; set; }
        public bool TakeDiscount { get; set; }
        public bool IsAdValorem { get; set; }
        public bool SendToFsa { get; set; }
    }
}
