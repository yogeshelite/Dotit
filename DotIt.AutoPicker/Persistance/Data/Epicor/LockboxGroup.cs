using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LockboxGroup
    {
        public LockboxGroup()
        {
            Lockbox = new HashSet<Lockbox>();
        }

        public string Company { get; set; }
        public string GroupId { get; set; }
        public DateTime? LockboxDate { get; set; }
        public string LayoutId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string ActiveUserId { get; set; }
        public bool PostingInProcess { get; set; }
        public string BankAcctId { get; set; }
        public int Pmuid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<Lockbox> Lockbox { get; set; }
    }
}
