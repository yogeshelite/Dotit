using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartSched
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public bool IsActive { get; set; }
        public string CalendarId { get; set; }
        public int PeriodicityCode1 { get; set; }
        public int PeriodicityCode2 { get; set; }
        public int PeriodShift { get; set; }
        public int MinDeliveryQty1 { get; set; }
        public int MinDeliveryQty2 { get; set; }
        public int MinForwardSpan { get; set; }
        public int FirmIncrease { get; set; }
        public int FirmDecrease { get; set; }
        public int OrderCover { get; set; }
        public int MaterialCover { get; set; }
        public int PrintLength { get; set; }
        public int ScheduleLength { get; set; }
        public int ScheduleFirm { get; set; }
        public string DevChar01 { get; set; }
        public string DevChar02 { get; set; }
        public string DevChar03 { get; set; }
        public string DevChar04 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
