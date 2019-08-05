using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DmrcorAct
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string CommentText { get; set; }
        public int NonConfNum { get; set; }
        public string AsigndTo { get; set; }
        public string AuditBy { get; set; }
        public string AuditCmts { get; set; }
        public string CauseInv { get; set; }
        public string Dept { get; set; }
        public DateTime? DateOpen { get; set; }
        public DateTime? DuDate { get; set; }
        public DateTime? AuditDt { get; set; }
        public DateTime? ActionComp { get; set; }
        public int Dmrnum { get; set; }
        public int ActionId { get; set; }
        public string CauseReasonCode { get; set; }
        public string CorrectiveActionReasonCode { get; set; }
        public int VendorNum { get; set; }
        public int ConNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
