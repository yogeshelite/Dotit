using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRlv
    {
        public string Company { get; set; }
        public decimal RlvId { get; set; }
        public int CustNum { get; set; }
        public string RlvRsnCd { get; set; }
        public DateTime? LvFrom { get; set; }
        public DateTime? LvTo { get; set; }
        public DateTime? ApvdOn { get; set; }
        public string ApvdBy { get; set; }
        public bool Ocsend { get; set; }
        public string OceventType { get; set; }
        public bool Ocready { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool SuspendCcservice { get; set; }
        public bool SuspendCcbilling { get; set; }
        public string BillingEquipId { get; set; }
        public string ServiceEquipId { get; set; }
    }
}
