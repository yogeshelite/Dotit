using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbStockProvisionFormat
    {
        public string Bucket1Caption { get; set; }
        public int Bucket1End { get; set; }
        public decimal Bucket1Rate { get; set; }
        public int Bucket1Start { get; set; }
        public bool Bucket2Active { get; set; }
        public string Bucket2Caption { get; set; }
        public int Bucket2End { get; set; }
        public decimal Bucket2Rate { get; set; }
        public bool Bucket3Active { get; set; }
        public string Bucket3Caption { get; set; }
        public int Bucket3End { get; set; }
        public decimal Bucket3Rate { get; set; }
        public bool Bucket4Active { get; set; }
        public string Bucket4Caption { get; set; }
        public int Bucket4End { get; set; }
        public decimal Bucket4Rate { get; set; }
        public bool Bucket5Active { get; set; }
        public string Bucket5Caption { get; set; }
        public int Bucket5End { get; set; }
        public decimal Bucket5Rate { get; set; }
        public bool Bucket6Active { get; set; }
        public string Bucket6Caption { get; set; }
        public int Bucket6End { get; set; }
        public decimal Bucket6Rate { get; set; }
        public string Company { get; set; }
        public string ComparedTo { get; set; }
        public string Description { get; set; }
        public string PartTranTypes { get; set; }
        public string StockProvFmtCode { get; set; }
        public string TimeModifier { get; set; }
        public string Type { get; set; }
        public string GlbCompany { get; set; }
        public string GlbStockProvFmtCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalStockProvisionFormat { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
