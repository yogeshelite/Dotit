using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class LockboxCheck
    {
        public LockboxCheck()
        {
            LockboxCheckDtl = new HashSet<LockboxCheckDtl>();
        }

        public string Company { get; set; }
        public string GroupId { get; set; }
        public string LockboxId { get; set; }
        public int LbcheckId { get; set; }
        public string BatchNum { get; set; }
        public DateTime? BatchDate { get; set; }
        public int BatchStubCount { get; set; }
        public decimal BatchTotalAmt { get; set; }
        public string CheckRef { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal CheckTotalAmt { get; set; }
        public bool CheckWoinvoices { get; set; }
        public string CustId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Lockbox Lockbox { get; set; }
        public virtual ICollection<LockboxCheckDtl> LockboxCheckDtl { get; set; }
    }
}
