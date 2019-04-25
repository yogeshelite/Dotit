using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbrestrictFcts
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string RestrictFct { get; set; }
        public string Description { get; set; }
        public string FctType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
