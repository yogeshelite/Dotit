using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCcempBasicCert
    {
        public string Company { get; set; }
        public int EmpBasicCertId { get; set; }
        public string EmpId { get; set; }
        public string CertificateCd { get; set; }
        public DateTime? EffDt { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Remark { get; set; }
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
