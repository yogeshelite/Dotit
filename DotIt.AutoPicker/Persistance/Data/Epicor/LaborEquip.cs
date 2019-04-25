using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LaborEquip
    {
        public string Company { get; set; }
        public int LaborHedSeq { get; set; }
        public int LaborDtlSeq { get; set; }
        public string EquipId { get; set; }
        public decimal Hours { get; set; }
        public decimal Qty { get; set; }
        public int CurrentMeter { get; set; }
        public string MeterUom { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
