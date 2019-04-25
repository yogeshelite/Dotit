using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacRabschDtlRates
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RabschHeadId { get; set; }
        public decimal RabschDtlId { get; set; }
        public decimal RabschDtlRatesId { get; set; }
        public decimal BschHeadId { get; set; }
        public decimal BschDtlId { get; set; }
        public decimal BschDtlRatesId { get; set; }
        public bool IsPct { get; set; }
        public string Per { get; set; }
        public decimal SetAmt { get; set; }
        public string LnTpCd { get; set; }
        public string TaxCd { get; set; }
        public decimal Rate { get; set; }
        public DateTime? EffDt { get; set; }
        public decimal OldRate { get; set; }
        public DateTime? OldEffDt { get; set; }
        public bool IsNew { get; set; }
        public bool IsBondLoanRebill { get; set; }
        public bool InactivePending { get; set; }
        public string OtherAmt { get; set; }
        public string OtherBcd { get; set; }
        public bool BillZeroRate { get; set; }
        public bool RatesOverridden { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public decimal Raid { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
