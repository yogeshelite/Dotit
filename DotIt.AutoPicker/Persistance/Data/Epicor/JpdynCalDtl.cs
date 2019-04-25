using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JpdynCalDtl
    {
        public string Company { get; set; }
        public string DynCalId { get; set; }
        public string Description { get; set; }
        public DateTime? DynDate { get; set; }
        public int Shifting { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
