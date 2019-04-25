using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FscontIv
    {
        public string Company { get; set; }
        public int ContractNum { get; set; }
        public int RenewalNbr { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int CustNum { get; set; }
        public string GroupId { get; set; }
        public int SoldToCustNum { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int LastInvoicedFiscalYear { get; set; }
        public string LastInvoicedFiscalYearSuffix { get; set; }
        public int LastInvoicedFiscalPeriod { get; set; }
    }
}
