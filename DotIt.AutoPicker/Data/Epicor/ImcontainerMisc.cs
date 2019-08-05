using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcontainerMisc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ContainerId { get; set; }
        public int MiscSeq { get; set; }
        public string MiscCode { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int MscNum { get; set; }
        public bool ExcludeFromLc { get; set; }
        public bool IncTransValue { get; set; }
        public string LcdisburseMethod { get; set; }
        public decimal EstimateAmt { get; set; }
        public decimal DocEstimateAmt { get; set; }
        public decimal ActualAmt { get; set; }
        public decimal DocActualAmt { get; set; }
        public string CurrencyCode { get; set; }
        public bool LockRate { get; set; }
        public string CommentText { get; set; }
        public decimal Rpt1EstimateAmt { get; set; }
        public decimal Rpt2EstimateAmt { get; set; }
        public decimal Rpt3EstimateAmt { get; set; }
        public decimal Rpt1ActualAmt { get; set; }
        public decimal Rpt2ActualAmt { get; set; }
        public decimal Rpt3ActualAmt { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string RateGrpCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal DocHstEstimateAmt { get; set; }
        public decimal HstEstimateAmt { get; set; }
        public decimal Rpt1HstEstimateAmt { get; set; }
        public decimal Rpt2HstEstimateAmt { get; set; }
        public decimal Rpt3HstEstimateAmt { get; set; }
        public string Type { get; set; }
        public decimal Percentage { get; set; }
        public string TaxCatId { get; set; }
        public bool Taxable { get; set; }
        public bool NoTaxRecalc { get; set; }
        public string TaxRegionCode { get; set; }
        public decimal InEstimateAmt { get; set; }
        public decimal DocInEstimateAmt { get; set; }
        public decimal Rpt1InEstimateAmt { get; set; }
        public decimal Rpt2InEstimateAmt { get; set; }
        public decimal Rpt3InEstimateAmt { get; set; }
        public decimal InHstEstimateAmt { get; set; }
        public decimal DocInHstEstimateAmt { get; set; }
        public decimal Rpt1InHstEstimateAmt { get; set; }
        public decimal Rpt2InHstEstimateAmt { get; set; }
        public decimal Rpt3InHstEstimateAmt { get; set; }
        public bool InPrice { get; set; }
    }
}
