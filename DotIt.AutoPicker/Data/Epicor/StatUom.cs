using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class StatUom
    {
        public string Company { get; set; }
        public string StatUomcode { get; set; }
        public string StatUomdesc { get; set; }
        public int NumOfDec { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
