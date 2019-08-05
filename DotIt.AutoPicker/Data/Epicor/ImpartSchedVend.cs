using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartSchedVend
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int PercentShare { get; set; }
        public int InspNextDelivery { get; set; }
        public int ContractPonum { get; set; }
        public int ContractPoline { get; set; }
        public bool DeliverMonday { get; set; }
        public bool DeliverTuesday { get; set; }
        public bool DeliverWednesday { get; set; }
        public bool DeliverThursday { get; set; }
        public bool DeliverFriday { get; set; }
        public bool DeliverSaturday { get; set; }
        public bool DeliverSunday { get; set; }
        public string DevChar01 { get; set; }
        public string DevChar02 { get; set; }
        public string DevChar03 { get; set; }
        public string DevChar04 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
