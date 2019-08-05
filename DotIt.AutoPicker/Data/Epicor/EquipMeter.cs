using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EquipMeter
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string EquipId { get; set; }
        public int TransNum { get; set; }
        public int MeterReading { get; set; }
        public string Comment { get; set; }
        public DateTime? ReadingDate { get; set; }
        public int ReadingTime { get; set; }
        public string DcdUserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
