using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCcleaveReason
    {
        public string Company { get; set; }
        public string LeaveReasonCd { get; set; }
        public string LeaveReasonDesc { get; set; }
        public string MedicareLeaveCd { get; set; }
        public bool Leave { get; set; }
        public bool SuspendService { get; set; }
        public bool SuspendBilling { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
