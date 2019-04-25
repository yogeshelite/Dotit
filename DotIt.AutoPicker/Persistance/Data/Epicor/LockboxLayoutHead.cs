using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LockboxLayoutHead
    {
        public LockboxLayoutHead()
        {
            LockboxLayoutDtl = new HashSet<LockboxLayoutDtl>();
        }

        public string Company { get; set; }
        public string LayoutId { get; set; }
        public string LayoutDescription { get; set; }
        public int DecPointPos { get; set; }
        public bool ReadyToUse { get; set; }
        public string DateFormat { get; set; }
        public bool AutoPost { get; set; }
        public bool UnderPayAutoPost { get; set; }
        public bool ValidateTotals { get; set; }
        public bool ErrorBatchDiscard { get; set; }
        public bool AllowOnAcc { get; set; }
        public bool OnInvoiceErrorSetOnAcc { get; set; }
        public bool AllowOverpayOnAcc { get; set; }
        public bool AllowOverpaidInv { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<LockboxLayoutDtl> LockboxLayoutDtl { get; set; }
    }
}
