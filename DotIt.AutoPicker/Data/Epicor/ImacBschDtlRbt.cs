using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacBschDtlRbt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal BschDtlRbtid { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal BschDtlId { get; set; }
        public decimal BschDtlRatesId { get; set; }
        public int CustNum { get; set; }
        public bool ChargeSchRate { get; set; }
        public decimal OvrAmt { get; set; }
        public bool IsPrct { get; set; }
        public string PrctBasis { get; set; }
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
    }
}
