using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartPc
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Pctype { get; set; }
        public string ProdCode { get; set; }
        public string Uomcode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
