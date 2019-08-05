using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RptLiterals
    {
        public string RptDefId { get; set; }
        public string LiteralName { get; set; }
        public string LiteralValue { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptDataDef RptDef { get; set; }
    }
}
