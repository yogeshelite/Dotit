using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LockboxCheckDtl
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string LockboxId { get; set; }
        public int LbcheckId { get; set; }
        public int SequenceNum { get; set; }
        public int BatchItem { get; set; }
        public int InvoiceNum { get; set; }
        public decimal PaymentAmt { get; set; }
        public int FileLineNbr { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual LockboxCheck LockboxCheck { get; set; }
    }
}
