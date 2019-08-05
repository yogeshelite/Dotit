using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Ccdtl
    {
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Plant { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public bool AllocationVariance { get; set; }
        public int CycleSeq { get; set; }
        public string PartNum { get; set; }
        public decimal TotFrozenVal { get; set; }
        public decimal TotFrozenQoh { get; set; }
        public int PostStatus { get; set; }
        public string Cdrcode { get; set; }
        public decimal TotCountVal { get; set; }
        public decimal TotCountQoh { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string RemovedBy { get; set; }
        public string MoveToCycle { get; set; }
        public decimal PcntTolerance { get; set; }
        public string Abccode { get; set; }
        public bool QtyToleranceUsed { get; set; }
        public bool PcntToleranceUsed { get; set; }
        public bool ValToleranceUsed { get; set; }
        public decimal QtyAdjTolerance { get; set; }
        public int VarToleranceStat { get; set; }
        public int PostAdjustment { get; set; }
        public decimal QtyTolerance { get; set; }
        public decimal ValueTolerance { get; set; }
        public string BaseUom { get; set; }
        public decimal TotActivityBeforeCount { get; set; }
        public decimal TotActivityBeforeVal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AddedByBlankTag { get; set; }
    }
}
