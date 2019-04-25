using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcRaaccomPayment
    {
        public string Company { get; set; }
        public decimal Raid { get; set; }
        public decimal RaaccomPayId { get; set; }
        public DateTime? EffDt { get; set; }
        public decimal AccomCost { get; set; }
        public decimal PaymentRecvd { get; set; }
        public string PaymentType { get; set; }
        public decimal LumpSumAmt { get; set; }
        public decimal PeriodicAmt { get; set; }
        public DateTime? PayDueDate { get; set; }
        public decimal Mpirrate { get; set; }
        public bool FixedRate { get; set; }
        public decimal Daprate { get; set; }
        public bool DrawnDown { get; set; }
        public string Comments { get; set; }
        public bool Inactive { get; set; }
        public DateTime? ExitNoticeDate { get; set; }
        public DateTime? RefundDueDate { get; set; }
        public DateTime? ProbateDate { get; set; }
        public DateTime? RefundDate { get; set; }
        public string RefundComment { get; set; }
        public bool Contribution { get; set; }
        public int CustNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public decimal AgreedAccomCost { get; set; }
        public bool IsLocked { get; set; }
        public decimal MaxContributionDay { get; set; }
        public decimal MaxContributionYear { get; set; }
        public decimal MaxLumpSum { get; set; }
        public string PaymentComment { get; set; }
        public string CreatedBy { get; set; }
    }
}
