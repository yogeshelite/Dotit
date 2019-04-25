using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PartRevInspPlan
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int SeqPlan { get; set; }
        public string InspPlanPartNum { get; set; }
        public string SpecId { get; set; }
        public string Plant { get; set; }
        public int SampleSize { get; set; }
        public decimal SampleSizePct { get; set; }
        public bool IsDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
