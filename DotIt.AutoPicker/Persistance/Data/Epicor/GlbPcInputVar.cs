using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcInputVar
    {
        public string Company { get; set; }
        public string VarName { get; set; }
        public string DataType { get; set; }
        public string InitValue { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
