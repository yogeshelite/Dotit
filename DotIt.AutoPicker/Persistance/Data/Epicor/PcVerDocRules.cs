using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcVerDocRules
    {
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
