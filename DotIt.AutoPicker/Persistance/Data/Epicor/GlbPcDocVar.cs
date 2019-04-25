using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcDocVar
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public int VarNum { get; set; }
        public string VarName { get; set; }
        public string DataType { get; set; }
        public string Expression { get; set; }
        public string ExprType { get; set; }
        public int VarSeq { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
