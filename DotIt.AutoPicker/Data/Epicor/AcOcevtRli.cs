using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcOcevtRli
    {
        public string Company { get; set; }
        public decimal OcevtRliid { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal RadtlId { get; set; }
        public int CustNum { get; set; }
        public string LiabilityType { get; set; }
        public DateTime? LiabilityStartDate { get; set; }
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
