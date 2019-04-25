using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacFacilitySummary
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
