using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlalcHed
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public string Description { get; set; }
        public string Basis { get; set; }
        public DateTime? LastDate { get; set; }
        public string LastUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
