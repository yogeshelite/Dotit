using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcInputsRule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public string ConfigId { get; set; }
        public string TargetInputName { get; set; }
        public int RuleSeq { get; set; }
        public string RuleDesc { get; set; }
        public string TargetInputProperty { get; set; }
        public string TargetInputValue { get; set; }
        public int ProcessSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
