using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbCustBillTo
    {
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public int GlbCustNum { get; set; }
        public int GlbBtcustNum { get; set; }
        public int CustNum { get; set; }
        public int BtcustNum { get; set; }
        public bool DefaultBillTo { get; set; }
        public bool InvoiceAddress { get; set; }
        public bool GlobalLock { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangedBy { get; set; }
        public int ChangeTime { get; set; }
        public string BtlegalName { get; set; }
        public string OrgRegCode { get; set; }
        public string OurBankCode { get; set; }
        public string TaxRegReason { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool FsacustomerNotSent { get; set; }
    }
}
