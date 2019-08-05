using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcOccupancy
    {
        public string Company { get; set; }
        public int OccupancyNum { get; set; }
        public string Facility { get; set; }
        public string SegCd { get; set; }
        public bool Occupied { get; set; }
        public string ClientCareType { get; set; }
        public int CustNum { get; set; }
        public string Rcscategory { get; set; }
        public string Acficategory { get; set; }
        public string Adlcategory { get; set; }
        public string Behcategory { get; set; }
        public string Chccategory { get; set; }
        public DateTime? OccupancyDate { get; set; }
        public DateTime? AvailableDate { get; set; }
        public decimal RtrfHistId { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
