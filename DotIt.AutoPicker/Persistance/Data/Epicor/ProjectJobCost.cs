using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ProjectJobCost
    {
        public string Company { get; set; }
        public string ProjectId { get; set; }
        public string JobNum { get; set; }
        public decimal LbrMin { get; set; }
        public decimal BurMin { get; set; }
        public decimal MtlMin { get; set; }
        public decimal SubMin { get; set; }
        public decimal MtlBurMin { get; set; }
        public decimal Odcmin { get; set; }
        public decimal TotActLbrCost { get; set; }
        public decimal TotActBurCost { get; set; }
        public decimal TotActMtlCost { get; set; }
        public decimal TotActSubCost { get; set; }
        public decimal TotActMtlBurCost { get; set; }
        public decimal TotActOdccost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PhaseId { get; set; }
        public string RevMethod { get; set; }
        public decimal MaterialRecAutoCstToDate { get; set; }
        public decimal LaborRecAutoCstToDate { get; set; }
        public decimal BurdenRecAutoCstToDate { get; set; }
        public decimal MtlBurdenRecAutoCstToDate { get; set; }
        public decimal SubConRecAutoCstToDate { get; set; }
        public decimal OdcrecAutoCstToDate { get; set; }
        public decimal LbrPur { get; set; }
        public decimal BurPur { get; set; }
        public decimal MtlPur { get; set; }
        public decimal SubPur { get; set; }
        public decimal MtlBurPur { get; set; }
        public decimal Odcpur { get; set; }
    }
}
