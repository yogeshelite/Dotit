using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptRuleCond
    {
        public string RptDefId { get; set; }
        public string RuleId { get; set; }
        public int Seq { get; set; }
        public string AndOr { get; set; }
        public string Lparens { get; set; }
        public string Rparens { get; set; }
        public string RuleTable { get; set; }
        public string RuleField { get; set; }
        public string CompOper { get; set; }
        public bool CompConst { get; set; }
        public string CompTable { get; set; }
        public string CompField { get; set; }
        public string CompValue { get; set; }
        public DateTime? CompDate { get; set; }
        public bool UseFromToday { get; set; }
        public int FromTodayDelta { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptRule R { get; set; }
    }
}
