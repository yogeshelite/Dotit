using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacCcservicePlanDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ServicePlanId { get; set; }
        public int ServicePlanDtlId { get; set; }
        public string Instructions { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndReason { get; set; }
        public bool OneOffService { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ServiceTypeCd { get; set; }
        public string ServiceTypeBillDesc { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string OpCode { get; set; }
        public string BillToBillingTypeCd { get; set; }
        public int BillToCustNum { get; set; }
        public bool NonBillable { get; set; }
        public string SaleTaxCd { get; set; }
        public string VendorTaxCd { get; set; }
    }
}
