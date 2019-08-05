using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptRule
    {
        public RptRule()
        {
            RptRuleCond = new HashSet<RptRuleCond>();
        }

        public string RptDefId { get; set; }
        public string RuleId { get; set; }
        public string ReportId { get; set; }
        public int StyleNum { get; set; }
        public string AutoPrinter { get; set; }
        public string PrintAction { get; set; }
        public bool PrintQtyConst { get; set; }
        public int PrintQtyValue { get; set; }
        public string PrintQtyTable { get; set; }
        public string PrintQtyField { get; set; }
        public int CondCount { get; set; }
        public bool CondValidated { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual Report Report { get; set; }
        public virtual ReportStyle ReportStyle { get; set; }
        public virtual RptDataDef RptDef { get; set; }
        public virtual ICollection<RptRuleCond> RptRuleCond { get; set; }
    }
}
