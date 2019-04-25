using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRuleType
    {
        public string Company { get; set; }
        public string RuleTypeCode { get; set; }
        public string RuleTypeDesc { get; set; }
        public string Program { get; set; }
        public bool GenerateSchedules { get; set; }
        public bool GenerateBilling { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string PartNum { get; set; }
        public string SubPart { get; set; }
        public bool EnableBrlog { get; set; }
    }
}
