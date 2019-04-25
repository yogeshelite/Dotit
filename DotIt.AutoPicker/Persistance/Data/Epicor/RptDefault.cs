using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptDefault
    {
        public string Company { get; set; }
        public string UserId { get; set; }
        public string ProgramId { get; set; }
        public string ParamSetId { get; set; }
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
