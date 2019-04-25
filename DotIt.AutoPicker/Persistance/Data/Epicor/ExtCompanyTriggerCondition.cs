using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtCompanyTriggerCondition
    {
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string SchemaName { get; set; }
        public string DbtableName { get; set; }
        public string TriggerType { get; set; }
        public int TriggerConditionGroupNum { get; set; }
        public int TriggerConditionNum { get; set; }
        public int OrderSeq { get; set; }
        public string Operator { get; set; }
        public string Prefix { get; set; }
        public string ConditionTypeName { get; set; }
        public string Postfix { get; set; }
        public string ExtCompCharacter01 { get; set; }
        public string ExtCompCharacter02 { get; set; }
        public bool ExtCompBoolean01 { get; set; }
        public bool ExtCompBoolean02 { get; set; }
        public DateTime? ExtCompDateTime01 { get; set; }
        public DateTime? ExtCompDateTime02 { get; set; }
        public int ExtCompInteger01 { get; set; }
        public int ExtCompInteger02 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
