using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRacatasAus
    {
        public string Company { get; set; }
        public decimal RacatasId { get; set; }
        public int CustNum { get; set; }
        public string CareType { get; set; }
        public string Other { get; set; }
        public int RespExtDays { get; set; }
        public bool Respite { get; set; }
        public bool Dementia { get; set; }
        public DateTime? EffDt { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool PermanentResCare { get; set; }
        public string RespCareType { get; set; }
        public bool CommCare { get; set; }
        public bool OtherCare { get; set; }
    }
}
