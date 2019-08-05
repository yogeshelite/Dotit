using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImapinvJob
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
        public string InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public decimal ExtCost { get; set; }
        public decimal Rpt1ExtCost { get; set; }
        public decimal Rpt2ExtCost { get; set; }
        public decimal Rpt3ExtCost { get; set; }
        public decimal DocExtCost { get; set; }
        public string ProjectId { get; set; }
        public string PhaseId { get; set; }
        public string MiscCode { get; set; }
        public bool ProjProcessed { get; set; }
        public DateTime? AsOfDate { get; set; }
        public int AsOfSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string EmpId { get; set; }
        public int EmpExpenseNum { get; set; }
        public Guid PartTranSysRowId { get; set; }
    }
}
