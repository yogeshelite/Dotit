using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImbankBatch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int SourceType { get; set; }
        public string BankBatchId { get; set; }
        public string BankAcctId { get; set; }
        public string CreatedBy { get; set; }
        public decimal BankAmount { get; set; }
        public string BankCurrency { get; set; }
        public DateTime? BatchDate { get; set; }
        public bool Reconciled { get; set; }
        public int BatchStatus { get; set; }
        public bool ReconcilePending { get; set; }
        public DateTime? ReconciledDate { get; set; }
        public string ReconciledTime { get; set; }
        public string ReconciledPerson { get; set; }
        public decimal CashBookNum { get; set; }
        public int CashBookLine { get; set; }
        public decimal ReconciledBankAmt { get; set; }
        public string BankSlip { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ActiveUserId { get; set; }
    }
}
