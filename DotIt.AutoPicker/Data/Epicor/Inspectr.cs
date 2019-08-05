using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Inspectr
    {
        public string Company { get; set; }
        public string InspectorId { get; set; }
        public string Name { get; set; }
        public bool InActive { get; set; }
        public string CnvEmpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
