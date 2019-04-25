using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImrptRule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
