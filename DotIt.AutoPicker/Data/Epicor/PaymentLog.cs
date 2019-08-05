using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PaymentLog
    {
        public string Company { get; set; }
        public int PaymentLogNum { get; set; }
        public string GroupId { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string PaymentType { get; set; }
        public string RecordType { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string ErrorText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
