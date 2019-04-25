using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Fsmisc
    {
        public string Company { get; set; }
        public int CallNum { get; set; }
        public int CallLine { get; set; }
        public int SeqNum { get; set; }
        public string MiscCode { get; set; }
        public string Description { get; set; }
        public decimal MiscAmt { get; set; }
        public decimal BillableMiscAmt { get; set; }
        public decimal DocMiscAmt { get; set; }
        public decimal DocBillableMiscAmt { get; set; }
        public bool Billable { get; set; }
        public DateTime? LastInvDate { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int ChangeTime { get; set; }
        public decimal Rpt1BillableMiscAmt { get; set; }
        public decimal Rpt2BillableMiscAmt { get; set; }
        public decimal Rpt3BillableMiscAmt { get; set; }
        public decimal Rpt1MiscAmt { get; set; }
        public decimal Rpt2MiscAmt { get; set; }
        public decimal Rpt3MiscAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
