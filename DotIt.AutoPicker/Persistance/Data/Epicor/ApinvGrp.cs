using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ApinvGrp
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string CreatedBy { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string ActiveUserId { get; set; }
        public string PostErrorLog { get; set; }
        public bool PostInProcess { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IsBoe { get; set; }
    }
}
