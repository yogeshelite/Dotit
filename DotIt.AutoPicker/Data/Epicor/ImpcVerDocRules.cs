using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcVerDocRules
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public string ExtCompanyId { get; set; }
        public int RuleSeq { get; set; }
        public string RuleString { get; set; }
        public string RuleType { get; set; }
        public string CalcName { get; set; }
        public string CalcDataType { get; set; }
        public string DbField { get; set; }
        public string DbTable { get; set; }
        public string SourceDbrecid { get; set; }
        public string Comments { get; set; }
        public string RuleExpr { get; set; }
        public int ProcessSeq { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
