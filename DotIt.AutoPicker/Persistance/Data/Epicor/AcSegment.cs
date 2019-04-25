using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcSegment
    {
        public string Company { get; set; }
        public decimal SegmentId { get; set; }
        public string SegName { get; set; }
        public bool SegReq { get; set; }
        public int SegmentLevel { get; set; }
        public string SegmentLevelDesc { get; set; }
        public string Description { get; set; }
        public int SegSeq { get; set; }
        public int Length { get; set; }
        public string Separator { get; set; }
        public int SegmentNbr { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
