using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysAgentTaskParam
    {
        public string AgentId { get; set; }
        public long AgentSchedNum { get; set; }
        public int AgentTaskNum { get; set; }
        public string ParamName { get; set; }
        public string ParamLabel { get; set; }
        public string ParamDataType { get; set; }
        public string ParamCharacter { get; set; }
        public DateTime? ParamDate { get; set; }
        public bool ParamLogical { get; set; }
        public int ParamInteger { get; set; }
        public decimal ParamDecimal { get; set; }
        public string ParamToken { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public long ParamLong { get; set; }
    }
}
