using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImrcvMisc
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
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int MiscSeq { get; set; }
        public string MiscCode { get; set; }
        public bool ExcludeFromLc { get; set; }
        public bool IncTransValue { get; set; }
        public string LcdisburseMethod { get; set; }
        public decimal ActualAmt { get; set; }
        public decimal DocActualAmt { get; set; }
        public string CurrencyCode { get; set; }
        public bool LockRate { get; set; }
        public string CommentText { get; set; }
        public decimal Rpt1ActualAmt { get; set; }
        public decimal Rpt2ActualAmt { get; set; }
        public decimal Rpt3ActualAmt { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string RateGrpCode { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int MscNum { get; set; }
        public decimal Percentage { get; set; }
        public string Type { get; set; }
        public int ApinvVendorNum { get; set; }
        public int PackLine { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TaxCatId { get; set; }
        public bool Taxable { get; set; }
        public bool NoTaxRecalc { get; set; }
        public decimal InActualAmt { get; set; }
        public decimal DocInActualAmt { get; set; }
        public decimal Rpt1InActualAmt { get; set; }
        public decimal Rpt2InActualAmt { get; set; }
        public decimal Rpt3InActualAmt { get; set; }
    }
}
