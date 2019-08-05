using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ecsyst
    {
        public string Company { get; set; }
        public bool AutoPost { get; set; }
        public bool UseDftShipTo { get; set; }
        public bool HoldOrders { get; set; }
        public string ImportFile { get; set; }
        public string ExportFile { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
