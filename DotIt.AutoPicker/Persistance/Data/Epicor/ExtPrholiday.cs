using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtPrholiday
    {
        public string Company { get; set; }
        public DateTime HolidayDate { get; set; }
        public string Description { get; set; }
        public decimal FullHours { get; set; }
        public decimal PartHours { get; set; }
        public decimal TempHours { get; set; }
        public decimal SeasonalHours { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
