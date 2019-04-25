using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcAssemblyUsing
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string AssemblyName { get; set; }
        public int UsingSeq { get; set; }
        public string UsingClause { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcAssembly PcAssembly { get; set; }
    }
}
