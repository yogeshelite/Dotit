using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FinRepConfHead
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string Description { get; set; }
        public string Coacode { get; set; }
        public bool IsSystem { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
