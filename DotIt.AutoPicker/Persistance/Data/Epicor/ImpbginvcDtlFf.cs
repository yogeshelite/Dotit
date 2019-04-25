using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImpbginvcDtlFf
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
        public int InvoiceLine { get; set; }
        public string TranType { get; set; }
        public string TranFile { get; set; }
        public string TranKey { get; set; }
        public string BillSchedId { get; set; }
        public string Manager { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public string ProdCode { get; set; }
        public decimal RetentionPcnt { get; set; }
        public bool ReduceInvByRet { get; set; }
        public string MeasuredWorkId { get; set; }
        public int DtlSeq { get; set; }
        public string ActivityUnit { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal ContractPrc { get; set; }
        public string ParentWrkSchId { get; set; }
        public string CustQtySurveyor { get; set; }
        public decimal ApprovalAmt { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string ActStatus { get; set; }
        public decimal RetentionAmt { get; set; }
        public decimal NettActivityAmt { get; set; }
        public decimal ActivityAmount { get; set; }
        public decimal CostPlusPrc { get; set; }
        public string QtySurveyor { get; set; }
        public decimal DocApprovalAmt { get; set; }
        public decimal Rpt1ApprovalAmt { get; set; }
        public decimal Rpt2ApprovalAmt { get; set; }
        public decimal Rpt3ApprovalAmt { get; set; }
        public decimal DocActivityAmount { get; set; }
        public decimal Rpt1ActivityAmount { get; set; }
        public decimal Rpt2ActivityAmount { get; set; }
        public decimal Rpt3ActivityAmount { get; set; }
        public decimal DocRetentionAmt { get; set; }
        public decimal Rpt1RetentionAmt { get; set; }
        public decimal Rpt2RetentionAmt { get; set; }
        public decimal Rpt3RetentionAmt { get; set; }
        public decimal DocNettActivityAmt { get; set; }
        public decimal Rpt1NettActivityAmt { get; set; }
        public decimal Rpt2NettActivityAmt { get; set; }
        public decimal Rpt3NettActivityAmt { get; set; }
        public decimal DocPricePerUnit { get; set; }
        public decimal Rpt1PricePerUnit { get; set; }
        public decimal Rpt2PricePerUnit { get; set; }
        public decimal Rpt3PricePerUnit { get; set; }
        public int ArinvoiceLine { get; set; }
        public string TaxCatId { get; set; }
        public string PhaseId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
