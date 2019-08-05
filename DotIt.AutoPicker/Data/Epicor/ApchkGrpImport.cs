using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ApchkGrpImport
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string CreatedBy { get; set; }
        public string ActiveUserId { get; set; }
        public string BankAcctId { get; set; }
        public DateTime? CheckDate { get; set; }
        public string CurrencyCode { get; set; }
        public bool Cashbook { get; set; }
        public string PostErrorLog { get; set; }
        public bool PostInProcess { get; set; }
        public string RateGrpCode { get; set; }
        public int Pmuid { get; set; }
        public bool PromissoryNote { get; set; }
        public bool EipaymSent { get; set; }
        public string GrpCreationVia { get; set; }
        public bool CompletelyMatched { get; set; }
        public bool MatchFlag { get; set; }
        public bool ImportedFlag { get; set; }
        public bool ProcessedFlag { get; set; }
        public decimal TotalStatementAmt { get; set; }
        public decimal MatchedAmt { get; set; }
        public decimal UnMatchedAmt { get; set; }
        public string ImportBankCode { get; set; }
        public string ImportStmtNbr { get; set; }
        public DateTime? ImportBankDate { get; set; }
        public int PaymentType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool NopaymentList { get; set; }
        public Guid BankBatchSysRowId { get; set; }
    }
}
