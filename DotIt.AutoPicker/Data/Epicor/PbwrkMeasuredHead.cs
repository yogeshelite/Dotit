using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PbwrkMeasuredHead
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string MeasuredWorkId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string ActivityUnit { get; set; }
        public string QtySurveyor { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalAmt { get; set; }
        public string ParentBillSchId { get; set; }
        public decimal PricePerUnit { get; set; }
        public string ParentWrkSchId { get; set; }
        public decimal CostPlusPrc { get; set; }
        public decimal ContractPrc { get; set; }
        public int LastDtlSeq { get; set; }
        public decimal DocPricePerUnit { get; set; }
        public decimal DocTotalAmt { get; set; }
        public decimal Rpt1PricePerUnit { get; set; }
        public decimal Rpt1TotalAmt { get; set; }
        public decimal Rpt2PricePerUnit { get; set; }
        public decimal Rpt2TotalAmt { get; set; }
        public decimal Rpt3PricePerUnit { get; set; }
        public decimal Rpt3TotalAmt { get; set; }
        public decimal Rpt3TotInvoiced { get; set; }
        public decimal Rpt2TotInvoiced { get; set; }
        public decimal Rpt1TotInvoiced { get; set; }
        public decimal TotInvoiced { get; set; }
        public decimal DocTotInvoiced { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
