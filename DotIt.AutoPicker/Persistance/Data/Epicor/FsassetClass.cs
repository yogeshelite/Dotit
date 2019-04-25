using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FsassetClass
    {
        public string Company { get; set; }
        public string FsassetClassCode { get; set; }
        public string FsassetClassDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
