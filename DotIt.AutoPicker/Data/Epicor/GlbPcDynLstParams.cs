using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcDynLstParams
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public int ListSeq { get; set; }
        public string ParamName { get; set; }
        public bool ParamConst { get; set; }
        public string ParamValue { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
