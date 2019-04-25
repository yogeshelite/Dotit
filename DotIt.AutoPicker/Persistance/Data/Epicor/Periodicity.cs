using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Periodicity
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
        public bool Code1Rules { get; set; }
        public int Code1DeliveryDay1 { get; set; }
        public int Code1DeliveryDay2 { get; set; }
        public bool Code2Rules { get; set; }
        public bool Code2IncludeSatSun { get; set; }
        public bool Code3Rules { get; set; }
        public int Code3DeliveryDay1 { get; set; }
        public int Code3WeekNumberInMonth { get; set; }
        public bool Code4Rules { get; set; }
        public int Code4DeliveryDayInWeek { get; set; }
        public bool Code5Rules { get; set; }
        public int Code5DeliveryDayInWeek { get; set; }
        public bool Code6Rules { get; set; }
        public int Code6DeliveryDayInMonth { get; set; }
        public bool Code7Rules { get; set; }
        public int Code7ShipmentDayInWeek { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
