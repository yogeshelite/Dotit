using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcOcevtCen
    {
        public string Company { get; set; }
        public decimal OcmsgHeadId { get; set; }
        public decimal OcevtCenid { get; set; }
        public int CustNum { get; set; }
        public string FinancialHardshipCode { get; set; }
        public string HoursOfService { get; set; }
        public string MinutesOfService { get; set; }
        public string Suburb { get; set; }
        public string Zip { get; set; }
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
