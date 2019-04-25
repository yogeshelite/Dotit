using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImapinvSel
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public bool Selected { get; set; }
        public string Name { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public decimal GrossPay { get; set; }
        public decimal DocGrossPay { get; set; }
        public decimal DiscAmt { get; set; }
        public decimal DocDiscAmt { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal NetPay { get; set; }
        public decimal DocNetPay { get; set; }
        public decimal InvoiceAmt { get; set; }
        public decimal DocInvoiceAmt { get; set; }
        public decimal InvoiceBal { get; set; }
        public decimal DocInvoiceBal { get; set; }
        public decimal AmtDue { get; set; }
        public decimal DocAmtDue { get; set; }
        public DateTime? LastPayDate { get; set; }
        public decimal DiscAvailable { get; set; }
        public decimal DocDiscAvailable { get; set; }
        public bool DebitMemo { get; set; }
        public DateTime? DiscountDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public bool LockRate { get; set; }
        public decimal Rpt1AmtDue { get; set; }
        public decimal Rpt2AmtDue { get; set; }
        public decimal Rpt3AmtDue { get; set; }
        public decimal Rpt1DiscAmt { get; set; }
        public decimal Rpt2DiscAmt { get; set; }
        public decimal Rpt3DiscAmt { get; set; }
        public decimal Rpt1DiscAvailable { get; set; }
        public decimal Rpt2DiscAvailable { get; set; }
        public decimal Rpt3DiscAvailable { get; set; }
        public decimal Rpt1GrossPay { get; set; }
        public decimal Rpt2GrossPay { get; set; }
        public decimal Rpt3GrossPay { get; set; }
        public decimal Rpt1InvoiceAmt { get; set; }
        public decimal Rpt2InvoiceAmt { get; set; }
        public decimal Rpt3InvoiceAmt { get; set; }
        public decimal Rpt1InvoiceBal { get; set; }
        public decimal Rpt2InvoiceBal { get; set; }
        public decimal Rpt3InvoiceBal { get; set; }
        public decimal Rpt1NetPay { get; set; }
        public decimal Rpt2NetPay { get; set; }
        public decimal Rpt3NetPay { get; set; }
        public string RateGrpCode { get; set; }
        public bool PrePayment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool PeisDetractionPayment { get; set; }
    }
}
