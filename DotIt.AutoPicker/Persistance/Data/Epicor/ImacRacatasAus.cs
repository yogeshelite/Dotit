using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRacatasAus
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
