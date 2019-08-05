using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImshopLoad
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public DateTime? LoadDate { get; set; }
        public decimal ActualHours { get; set; }
        public bool OverLoaded { get; set; }
        public decimal HoursOver { get; set; }
        public decimal PercOver { get; set; }
        public bool InformOverloaded { get; set; }
        public decimal Wihours { get; set; }
        public bool WioverLoaded { get; set; }
        public decimal WihoursOver { get; set; }
        public decimal WipercOver { get; set; }
        public bool WiinformOverloaded { get; set; }
        public decimal NonTimeCapacity { get; set; }
        public decimal WinonTimeCapacity { get; set; }
        public decimal DailyProdQty { get; set; }
        public decimal WidailyProdQty { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
