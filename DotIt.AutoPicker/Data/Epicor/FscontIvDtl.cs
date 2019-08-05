using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FscontIvDtl
    {
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public int RenewalNbr { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int ContractLine { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int LastInvoicedFiscalYear { get; set; }
        public string LastInvoicedFiscalYearSuffix { get; set; }
        public int LastInvoicedFiscalPeriod { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}
