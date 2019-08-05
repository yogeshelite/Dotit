using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PerBillStmtPay
    {
        public string Company { get; set; }
        public string PerBillStmtGrpId { get; set; }
        public int CustNum { get; set; }
        public int StmtPayLineNum { get; set; }
        public string PayGroupId { get; set; }
        public int PayHeadNum { get; set; }
        public int PayInvoiceNum { get; set; }
        public int PayInvoiceRef { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
