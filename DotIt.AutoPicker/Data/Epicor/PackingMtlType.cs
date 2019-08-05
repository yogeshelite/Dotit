using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PackingMtlType
    {
        public string Company { get; set; }
        public string PkgMtlTypeCode { get; set; }
        public string PkgMtlTypeCodeDesc { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
