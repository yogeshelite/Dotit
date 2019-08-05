using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImprocessTaskParam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string SystemCode { get; set; }
        public string ProcessId { get; set; }
        public int SysTaskNum { get; set; }
        public string ParamName { get; set; }
        public string ParamLabel { get; set; }
        public string ParamType { get; set; }
        public string ParamDataType { get; set; }
        public string ParamCharacter { get; set; }
        public DateTime? ParamDate { get; set; }
        public bool ParamLogical { get; set; }
        public int ParamInteger { get; set; }
        public decimal ParamDecimal { get; set; }
        public string ParamToken { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public long ParamLong { get; set; }
    }
}
