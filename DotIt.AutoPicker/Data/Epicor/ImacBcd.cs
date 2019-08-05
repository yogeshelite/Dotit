using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacBcd
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Bcd { get; set; }
        public string Bcddesc { get; set; }
        public string BcdbillDesc { get; set; }
        public string TaxCd { get; set; }
        public string BillGroupCd { get; set; }
        public bool AllowRateChg { get; set; }
        public string RuleTypeCode { get; set; }
        public string RuleCode { get; set; }
        public bool SystemFlag { get; set; }
        public bool BillZeroRate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool IsResidential { get; set; }
        public bool IsCommCare { get; set; }
        public bool IsServiceType { get; set; }
        public string ExpenditureType { get; set; }
        public string CallCode { get; set; }
        public bool NonBillable { get; set; }
        public string Category { get; set; }
        public string IncomeBcd { get; set; }
    }
}
