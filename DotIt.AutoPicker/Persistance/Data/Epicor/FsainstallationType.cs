using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FsainstallationType
    {
        public string Company { get; set; }
        public string TypeCode { get; set; }
        public string Description { get; set; }
        public int FsatemplateServiceOrderId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
