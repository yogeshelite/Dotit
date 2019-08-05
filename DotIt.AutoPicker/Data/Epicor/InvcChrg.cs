using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class InvcChrg
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int SeqNum { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal ChargeAmt { get; set; }
        public string ChargeCode { get; set; }
        public decimal ChargePercent { get; set; }
        public int InvoiceLine { get; set; }
        public int SourceInvoiceNum { get; set; }
        public decimal DocChargeAmt { get; set; }
        public decimal Rpt1ChargeAmt { get; set; }
        public decimal Rpt2ChargeAmt { get; set; }
        public decimal Rpt3ChargeAmt { get; set; }
        public bool ReminderPreview { get; set; }
        public int LetterNum { get; set; }
        public bool Manual { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal OutstandingBalance { get; set; }
        public decimal DocOutstandingBalance { get; set; }
        public decimal Rpt1OutstandingBalance { get; set; }
        public decimal Rpt2OutstandingBalance { get; set; }
        public decimal Rpt3OutstandingBalance { get; set; }
    }
}
