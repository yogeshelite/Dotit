using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImarprepaymentTran
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int HeadNum { get; set; }
        public int InvoiceNum { get; set; }
        public int MovementNum { get; set; }
        public int InvoiceLine { get; set; }
        public int CustNum { get; set; }
        public int OrderNum { get; set; }
        public string CurrencyCode { get; set; }
        public string TranType { get; set; }
        public DateTime? TranDate { get; set; }
        public int RefInvoiceNum { get; set; }
        public int RefInvoiceLine { get; set; }
        public decimal AllocatedAmt { get; set; }
        public decimal DocAllocatedAmt { get; set; }
        public decimal Rpt1AllocatedAmt { get; set; }
        public decimal Rpt2AllocatedAmt { get; set; }
        public decimal Rpt3AllocatedAmt { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
