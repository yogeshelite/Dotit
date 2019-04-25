using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxSvcHead
    {
        public string Company { get; set; }
        public string TaxSvcId { get; set; }
        public int OrderNum { get; set; }
        public int InvoiceNum { get; set; }
        public DateTime? DocDate { get; set; }
        public int CustNum { get; set; }
        public string DocCodes { get; set; }
        public string DocState { get; set; }
        public string RemoteState { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalTax { get; set; }
        public decimal TotalDiscount { get; set; }
        public bool Reconciled { get; set; }
        public int DocType { get; set; }
        public int DocId { get; set; }
        public string DocDisplaySymbol { get; set; }
        public int QuoteNum { get; set; }
        public DateTime? DateCreated { get; set; }
        public int TimeCreated { get; set; }
        public string TchdocCode { get; set; }
        public string TchremoteState { get; set; }
        public decimal TchtotalAmount { get; set; }
        public decimal TchtotalDiscount { get; set; }
        public decimal TchtotalTax { get; set; }
        public string ResultCode { get; set; }
        public DateTime? TchdocDate { get; set; }
        public string Action { get; set; }
        public string LastReconAction { get; set; }
        public string ApinvoiceNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
