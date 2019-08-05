using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustShipViaDlvInfo
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public string ShipViaCode { get; set; }
        public int DemandDeliveryDays { get; set; }
        public int PeriodicityCode { get; set; }
        public string DemandDateType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
