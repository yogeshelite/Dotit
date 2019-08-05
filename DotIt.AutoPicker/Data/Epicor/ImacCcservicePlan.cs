using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacCcservicePlan
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
        public int CustNum { get; set; }
        public int AreaId { get; set; }
        public string PackageCd { get; set; }
        public string Manager { get; set; }
        public DateTime? ReviewDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EndReason { get; set; }
        public string EndReasonDesc { get; set; }
        public DateTime? FundingStartDate { get; set; }
        public DateTime? FundingEndDate { get; set; }
        public string FundingSource { get; set; }
        public int LocationId { get; set; }
        public string FinSocialDisadvantage { get; set; }
        public int ServiceHours { get; set; }
        public int ServiceMinutes { get; set; }
        public string AddressType { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Cdcenable { get; set; }
        public DateTime? CdcstartDate { get; set; }
        public bool Ocready { get; set; }
    }
}
