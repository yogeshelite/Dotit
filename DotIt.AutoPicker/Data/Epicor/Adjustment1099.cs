using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Adjustment1099
    {
        public string Company { get; set; }
        public string FormTypeId { get; set; }
        public int AdjustmentNum { get; set; }
        public int TaxYear { get; set; }
        public int VendorNum { get; set; }
        public string Code1099Id { get; set; }
        public decimal AdjustmentAmt { get; set; }
        public decimal SubmittedAmt { get; set; }
        public string Reason { get; set; }
        public string Gen1099Code { get; set; }
        public DateTime? Gen1099Date { get; set; }
        public string Tin { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Us1099ktranType { get; set; }
        public string Us1099kmerchCatCode { get; set; }

        public virtual FormType FormType { get; set; }
    }
}
