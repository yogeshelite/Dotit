using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AssemblyStore
    {
        public string AssemblyName { get; set; }
        public byte[] AssemblyContent { get; set; }
        public DateTime ModifiedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
