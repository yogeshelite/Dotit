using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RlsClass
    {
        public string Company { get; set; }
        public string RlsClassCode { get; set; }
        public string Description { get; set; }
        public bool Tiered { get; set; }
        public bool RlsGlobal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
