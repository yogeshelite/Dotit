using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcOcevtCdp
    {
        public string Company { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal OcevtCdpid { get; set; }
        public int CustNum { get; set; }
        public string DepartReason { get; set; }
        public DateTime? DepartureDate { get; set; }
        public string HoursOfService { get; set; }
        public string MinutesOfService { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
    }
}
