using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpapperBillStmtPay
    {
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public int VendorNum { get; set; }
        public int StmtPayLineNum { get; set; }
        public int PayHeadNum { get; set; }
        public string PayInvoiceNum { get; set; }
        public bool PayVoided { get; set; }
        public int PayAptranNo { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual JpapperBillStmtHead JpapperBillStmtHead { get; set; }
    }
}
