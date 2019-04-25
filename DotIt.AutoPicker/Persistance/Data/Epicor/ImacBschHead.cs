using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacBschHead
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal BschHeadId { get; set; }
        public string BschHeadCd { get; set; }
        public string BschHeadDesc { get; set; }
        public bool IsRecon { get; set; }
        public string BcycleCd { get; set; }
        public bool OnePerInv { get; set; }
        public string InvDesc { get; set; }
        public bool AllowDuplicate { get; set; }
        public bool Confirmed { get; set; }
        public string RuleTypeCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool IsResidential { get; set; }
        public bool IsCommCare { get; set; }
    }
}
