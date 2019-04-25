using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCclocation
    {
        public string Company { get; set; }
        public int LocationId { get; set; }
        public DateTime? EffDt { get; set; }
        public string Locality { get; set; }
        public string PostCode { get; set; }
        public string Arianame { get; set; }
        public decimal Ariascore { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
