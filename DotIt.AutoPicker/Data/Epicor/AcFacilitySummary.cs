using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcFacilitySummary
    {
        public string Company { get; set; }
        public int SummaryId { get; set; }
        public Guid BillingGuid { get; set; }
        public int FacilityNum { get; set; }
        public DateTime? TranDate { get; set; }
        public int Assisted { get; set; }
        public int Concessional { get; set; }
        public int AccomSupp { get; set; }
        public int Hardship { get; set; }
        public int Post97Resident { get; set; }
        public int SfacpostResident { get; set; }
        public string Racsid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int HardshipSfacpost { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public int LowMeans { get; set; }
    }
}
