using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JpapperBillStmtDtl
    {
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public int VendorNum { get; set; }
        public string InvoiceNum { get; set; }
        public string BillingNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual JpapperBillStmtHead JpapperBillStmtHead { get; set; }
    }
}
