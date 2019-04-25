using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcSegCt
    {
        public string Company { get; set; }
        public string SegCtcd { get; set; }
        public string SegCtdesc { get; set; }
        public bool Bond { get; set; }
        public bool Loan { get; set; }
        public bool SystemFlag { get; set; }
        public string CareCat { get; set; }
        public bool Respite { get; set; }
        public bool UpdateTerritory { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string ClinicalSegCtcd { get; set; }
    }
}
