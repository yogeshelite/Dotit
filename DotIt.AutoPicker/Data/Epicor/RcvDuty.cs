using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RcvDuty
    {
        public RcvDuty()
        {
            RcvDutyTax = new HashSet<RcvDutyTax>();
        }

        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public string PackSlip { get; set; }
        public int PackLine { get; set; }
        public int DutySeq { get; set; }
        public string TariffCode { get; set; }
        public decimal DutyAmt { get; set; }
        public string CommentText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal InDutyAmt { get; set; }

        public virtual ICollection<RcvDutyTax> RcvDutyTax { get; set; }
    }
}
