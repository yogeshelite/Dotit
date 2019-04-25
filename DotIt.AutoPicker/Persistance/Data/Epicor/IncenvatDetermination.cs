using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IncenvatDetermination
    {
        public string Company { get; set; }
        public string CenvatCode { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string OutputPartNum { get; set; }
        public string ExciseRegister { get; set; }
        public bool InActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
