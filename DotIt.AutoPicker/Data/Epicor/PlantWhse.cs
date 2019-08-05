using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PlantWhse
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string WarehouseCode { get; set; }
        public string PrimBin { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
