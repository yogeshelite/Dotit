using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SubLedgerTransaction
    {
        public string Company { get; set; }
        public string BankAcctId { get; set; }
        public decimal CashBookNum { get; set; }
        public int DocumentType { get; set; }
        public string Reference { get; set; }
        public int CashBookLine { get; set; }
        public int DocumentTypeMode { get; set; }
        public string Partner { get; set; }
        public string PartnerName { get; set; }
        public int PartnerNum { get; set; }
        public bool DocumentStatus { get; set; }
        public string LegalNumber { get; set; }
        public string InternalNumber { get; set; }
        public decimal DocAmount { get; set; }
        public string DocCurrency { get; set; }
        public DateTime? DocDate { get; set; }
        public decimal BankAmount { get; set; }
        public string BankCurrency { get; set; }
        public string GroupId { get; set; }
        public decimal BaseAmount { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string SuggestedForLines { get; set; }
        public string BankBatchRef { get; set; }
        public Guid ExternalSysRowId { get; set; }
        public Guid BankBatchSysRowId { get; set; }
    }
}
