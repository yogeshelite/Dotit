using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class InvcReminder
    {
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public string GroupCode { get; set; }
        public int Sequence { get; set; }
        public DateTime? GenDate { get; set; }
        public string LegalNumber { get; set; }
        public string InvoiceType { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal InvoiceAmt { get; set; }
        public decimal InvoiceBal { get; set; }
        public string CurrencyCode { get; set; }
        public int LetterNum { get; set; }
        public decimal FinChargeAmt { get; set; }
        public decimal Payments { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
