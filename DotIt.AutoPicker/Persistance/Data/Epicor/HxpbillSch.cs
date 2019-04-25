using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxpbillSch
    {
        public int Revision { get; set; }
        public string BillSchedId { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public decimal DocTotInvoiced { get; set; }
        public decimal DocTotRetention { get; set; }
        public decimal DocTotValue { get; set; }
        public bool InActive { get; set; }
        public int LiabilityMonths { get; set; }
        public string Manager { get; set; }
        public DateTime? NextDate { get; set; }
        public int NumInvoices { get; set; }
        public int OrderLine { get; set; }
        public int OrderNum { get; set; }
        public bool PostRetProdGrp { get; set; }
        public string ProdCode { get; set; }
        public string ProjectId { get; set; }
        public bool ReduceInvByRet { get; set; }
        public decimal RetentionPcnt { get; set; }
        public decimal Rpt1TotInvoiced { get; set; }
        public decimal Rpt1TotRetention { get; set; }
        public decimal Rpt1TotValue { get; set; }
        public decimal Rpt2TotInvoiced { get; set; }
        public decimal Rpt2TotRetention { get; set; }
        public decimal Rpt2TotValue { get; set; }
        public decimal Rpt3TotInvoiced { get; set; }
        public decimal Rpt3TotRetention { get; set; }
        public decimal Rpt3TotValue { get; set; }
        public string SchedFreq { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal TotInvoiced { get; set; }
        public decimal TotRetention { get; set; }
        public decimal TotValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
