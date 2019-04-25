using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglbPcInputsRuleDef
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
        public int SeqNum { get; set; }
        public string SourceInputName { get; set; }
        public string SourceInputProperty { get; set; }
        public string SourceCharacterValue { get; set; }
        public int SourceIntegerValue { get; set; }
        public decimal SourceDecimalValue { get; set; }
        public DateTime? SourceDateValue { get; set; }
        public bool SourceLogicalValue { get; set; }
        public int ProcessSeq { get; set; }
        public string LeftP { get; set; }
        public string RightP { get; set; }
        public string AndOr { get; set; }
        public string CompOp { get; set; }
        public bool Neg { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
