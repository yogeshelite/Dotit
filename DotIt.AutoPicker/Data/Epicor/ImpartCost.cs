using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartCost
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string CostId { get; set; }
        public decimal AvgLaborCost { get; set; }
        public decimal AvgBurdenCost { get; set; }
        public decimal AvgMaterialCost { get; set; }
        public decimal AvgSubContCost { get; set; }
        public decimal AvgMtlBurCost { get; set; }
        public decimal StdLaborCost { get; set; }
        public decimal StdBurdenCost { get; set; }
        public decimal StdMaterialCost { get; set; }
        public decimal StdSubContCost { get; set; }
        public decimal StdMtlBurCost { get; set; }
        public decimal LastLaborCost { get; set; }
        public decimal LastBurdenCost { get; set; }
        public decimal LastMaterialCost { get; set; }
        public decimal LastSubContCost { get; set; }
        public decimal LastMtlBurCost { get; set; }
        public decimal FifoavgLaborCost { get; set; }
        public decimal FifoavgBurdenCost { get; set; }
        public decimal FifoavgMaterialCost { get; set; }
        public decimal FifoavgSubContCost { get; set; }
        public decimal FifoavgMtlBurCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal TotalQtyAvg { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
    }
}
