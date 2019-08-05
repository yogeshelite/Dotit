using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpbillHistory
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
        public string BillSchedId { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public decimal InvcLineAmt { get; set; }
        public decimal RetentionAmt { get; set; }
        public decimal DocInvcLineAmt { get; set; }
        public decimal Rpt1InvcLineAmt { get; set; }
        public decimal Rpt2InvcLineAmt { get; set; }
        public decimal Rpt3InvcLineAmt { get; set; }
        public decimal DocRetentionAmt { get; set; }
        public decimal Rpt1RetentionAmt { get; set; }
        public decimal Rpt2RetentionAmt { get; set; }
        public decimal Rpt3RetentionAmt { get; set; }
        public string MeasuredWorkId { get; set; }
        public int DtlSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
