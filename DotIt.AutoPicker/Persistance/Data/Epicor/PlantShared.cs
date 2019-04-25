using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PlantShared
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string WarehouseCode { get; set; }
        public string RemotePlant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
