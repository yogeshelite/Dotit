using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CartonStage
    {
        public string Company { get; set; }
        public int PackNum { get; set; }
        public string StageNumber { get; set; }
        public string ShipmentType { get; set; }
        public bool Shipped { get; set; }
        public string ShipViaCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ProcessError { get; set; }
    }
}
