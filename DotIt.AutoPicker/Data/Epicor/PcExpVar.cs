using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcExpVar
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string VarName { get; set; }
        public string DataType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
