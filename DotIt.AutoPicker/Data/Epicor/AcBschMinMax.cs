using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcBschMinMax
    {
        public string Company { get; set; }
        public decimal BschMinMaxId { get; set; }
        public decimal BschHeadId { get; set; }
        public string Frequency { get; set; }
        public int Period { get; set; }
        public decimal MinVal { get; set; }
        public decimal MaxVal { get; set; }
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
