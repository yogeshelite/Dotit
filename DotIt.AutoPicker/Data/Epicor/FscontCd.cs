using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FscontCd
    {
        public string Company { get; set; }
        public string ContractCode { get; set; }
        public string ContractDescription { get; set; }
        public int Duration { get; set; }
        public string Modifier { get; set; }
        public bool Material { get; set; }
        public bool Labor { get; set; }
        public bool Misc { get; set; }
        public bool Closed { get; set; }
        public decimal UnitPrice { get; set; }
        public string CommentText { get; set; }
        public bool OnSite { get; set; }
        public bool RecurringInv { get; set; }
        public string RecurringFreq { get; set; }
        public string PricePer { get; set; }
        public string TaxCatId { get; set; }
        public string IncomeTaxCode { get; set; }
        public bool GlobalFscontCd { get; set; }
        public bool GlobalLock { get; set; }
        public bool DeferredRev { get; set; }
        public string Racode { get; set; }
        public bool ShipContract { get; set; }
        public string RenewalCode { get; set; }
        public bool ShipRenewal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string FiscalCalendarId { get; set; }
        public bool Renewable { get; set; }
        public bool QuotedContract { get; set; }
        public string TaskSetId { get; set; }
        public bool SendToFsa { get; set; }
    }
}
