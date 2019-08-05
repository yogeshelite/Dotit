using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpbginvcBdn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public int InvoiceNum { get; set; }
        public string BdnSetId { get; set; }
        public string BdnCd { get; set; }
        public decimal BdnPrc { get; set; }
        public decimal BdnLbrAmt { get; set; }
        public decimal BdnConLbrAmt { get; set; }
        public decimal BdnSubAmt { get; set; }
        public decimal BdnMtlAmt { get; set; }
        public decimal BdnMiscAmt { get; set; }
        public int RecSeq { get; set; }
        public DateTime? RecDate { get; set; }
        public decimal DocBdnLbrAmt { get; set; }
        public decimal Rpt1BdnLbrAmt { get; set; }
        public decimal Rpt2BdnLbrAmt { get; set; }
        public decimal Rpt3BdnLbrAmt { get; set; }
        public decimal DocBdnConLbrAmt { get; set; }
        public decimal Rpt1BdnConLbrAmt { get; set; }
        public decimal Rpt2BdnConLbrAmt { get; set; }
        public decimal Rpt3BdnConLbrAmt { get; set; }
        public decimal DocBdnSubAmt { get; set; }
        public decimal Rpt1BdnSubAmt { get; set; }
        public decimal Rpt2BdnSubAmt { get; set; }
        public decimal Rpt3BdnSubAmt { get; set; }
        public decimal DocBdnMtlAmt { get; set; }
        public decimal Rpt1BdnMtlAmt { get; set; }
        public decimal Rpt2BdnMtlAmt { get; set; }
        public decimal Rpt3BdnMtlAmt { get; set; }
        public decimal DocBdnMiscAmt { get; set; }
        public decimal Rpt1BdnMiscAmt { get; set; }
        public decimal Rpt2BdnMiscAmt { get; set; }
        public decimal Rpt3BdnMiscAmt { get; set; }
        public decimal DocActTotalAmt { get; set; }
        public decimal DocInvTotalAmt { get; set; }
        public decimal ActTotalAmt { get; set; }
        public decimal Rpt1ActTotalAmt { get; set; }
        public decimal Rpt2ActTotalAmt { get; set; }
        public decimal Rpt3ActTotalAmt { get; set; }
        public decimal InvTotalAmt { get; set; }
        public decimal Rpt1InvTotalAmt { get; set; }
        public decimal Rpt2InvTotalAmt { get; set; }
        public decimal Rpt3InvTotalAmt { get; set; }
        public decimal BdnRuleAmt { get; set; }
        public decimal DocBdnRuleAmt { get; set; }
        public decimal Rpt1BdnRuleAmt { get; set; }
        public decimal Rpt2BdnRuleAmt { get; set; }
        public decimal Rpt3BdnRuleAmt { get; set; }
        public string TaxCatId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
