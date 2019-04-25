using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImjpapperBillStmtPay
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
