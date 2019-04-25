using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ShopLoad
    {
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
