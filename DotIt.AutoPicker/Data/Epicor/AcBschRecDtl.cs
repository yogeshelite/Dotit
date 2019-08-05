using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcBschRecDtl
    {
        public string Company { get; set; }
        public decimal BschRecDtlId { get; set; }
        public decimal BschRecHeadId { get; set; }
        public decimal Raid { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
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
