using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcAdjDtl
    {
        public string Company { get; set; }
        public decimal AdjDtlId { get; set; }
        public decimal AdjHeadId { get; set; }
        public decimal AdjGrpId { get; set; }
        public string Bcd { get; set; }
        public string Bcddesc { get; set; }
        public decimal Amount { get; set; }
        public string TermsCode { get; set; }
        public int CustNum { get; set; }
        public string BillingTypeCd { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public int ServicePlanId { get; set; }
    }
}
