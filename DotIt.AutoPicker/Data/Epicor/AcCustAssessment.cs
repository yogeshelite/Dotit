using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcCustAssessment
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public decimal CustAssessmentId { get; set; }
        public DateTime? EffDt { get; set; }
        public string ClassType { get; set; }
        public decimal AccomCharge { get; set; }
        public decimal AccomContribution { get; set; }
        public decimal Mtcf { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public string CreatedBy { get; set; }
    }
}
