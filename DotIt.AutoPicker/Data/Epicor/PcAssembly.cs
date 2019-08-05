using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcAssembly
    {
        public PcAssembly()
        {
            PcAssemblyUsing = new HashSet<PcAssemblyUsing>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string AssemblyName { get; set; }
        public string Alias { get; set; }
        public string Path { get; set; }
        public int IncludeIn { get; set; }
        public bool ExternalAssembly { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<PcAssemblyUsing> PcAssemblyUsing { get; set; }
    }
}
