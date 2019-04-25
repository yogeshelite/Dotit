using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VntgPatchLevel
    {
        public int PatchLevel { get; set; }
        public DateTime? InstallDate { get; set; }
        public int InstallTime { get; set; }
        public string InstallUserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
