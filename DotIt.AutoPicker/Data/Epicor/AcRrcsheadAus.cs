using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcRrcsheadAus
    {
        public string Company { get; set; }
        public decimal RrcsheadId { get; set; }
        public int CustNum { get; set; }
        public DateTime? AsDt { get; set; }
        public string CmpltBy { get; set; }
        public DateTime? EffDt { get; set; }
        public string CertifiedBy { get; set; }
        public string CertifiedByPos { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public decimal AsTotal { get; set; }
        public string RrcscatCd { get; set; }
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
