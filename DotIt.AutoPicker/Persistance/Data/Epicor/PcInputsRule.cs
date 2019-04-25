using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcInputsRule
    {
        public PcInputsRule()
        {
            PcInputsRuleDef = new HashSet<PcInputsRuleDef>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string TargetInputName { get; set; }
        public int RuleSeq { get; set; }
        public string RuleDesc { get; set; }
        public string TargetInputProperty { get; set; }
        public string TargetInputValue { get; set; }
        public int ProcessSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcInputs PcInputs { get; set; }
        public virtual ICollection<PcInputsRuleDef> PcInputsRuleDef { get; set; }
    }
}
