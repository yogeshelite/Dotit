using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PackingType
    {
        public string Company { get; set; }
        public string PkgTypeCode { get; set; }
        public string PkgTypeDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
