using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacRabondAus
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal RabondAusid { get; set; }
        public decimal Raid { get; set; }
        public decimal AgreedBondAmt { get; set; }
        public string BondType { get; set; }
        public DateTime? EffDt { get; set; }
        public decimal LumpSumAmt { get; set; }
        public decimal PeriodicAmt { get; set; }
        public decimal BondReceived { get; set; }
        public decimal BondOutstanding { get; set; }
        public DateTime? DueDate { get; set; }
        public bool RollOver { get; set; }
        public string RolloverType { get; set; }
        public decimal RolloverAmt { get; set; }
        public decimal RolloverMthsPd { get; set; }
        public decimal RolloverRetAmt { get; set; }
        public decimal RolloverBal { get; set; }
        public decimal RolloverRetPaid { get; set; }
        public DateTime? ExitNoticeDate { get; set; }
        public DateTime? ProbateDate { get; set; }
        public DateTime? RefundDueDate { get; set; }
        public DateTime? RefundDate { get; set; }
        public string RefundComment { get; set; }
        public string BondComment { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public int CustNum { get; set; }
        public string GroupId { get; set; }
        public int HeadNum { get; set; }
        public decimal RolloverMthsPdPrd { get; set; }
        public decimal RolloverDaysPdPrd { get; set; }
        public decimal RolloverRetAmtPrd { get; set; }
        public decimal RolloverRetPaidPrd { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
