using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbFscontCd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public bool Closed { get; set; }
        public string CommentText { get; set; }
        public string Company { get; set; }
        public string ContractCode { get; set; }
        public string ContractDescription { get; set; }
        public int Duration { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool Labor { get; set; }
        public bool Material { get; set; }
        public bool Misc { get; set; }
        public string Modifier { get; set; }
        public bool OnSite { get; set; }
        public string PricePer { get; set; }
        public string RecurringFreq { get; set; }
        public bool RecurringInv { get; set; }
        public string TaxCatId { get; set; }
        public decimal UnitPrice { get; set; }
        public string GlbCompany { get; set; }
        public string GlbContractCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFscontCd { get; set; }
        public bool GlobalLock { get; set; }
        public bool DeferredRev { get; set; }
        public string Racode { get; set; }
        public string RenewalCode { get; set; }
        public bool ShipContract { get; set; }
        public bool ShipRenewal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
