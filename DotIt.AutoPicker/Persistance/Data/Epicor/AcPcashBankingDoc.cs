using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcPcashBankingDoc
    {
        public string Company { get; set; }
        public string CashDeskId { get; set; }
        public int ReferenceNum { get; set; }
        public int BankingId { get; set; }
        public int CustNum { get; set; }
        public DateTime? ApplyDate { get; set; }
        public int PayMethodPmuid { get; set; }
        public string PayMethodName { get; set; }
        public decimal DocCashAmt { get; set; }
        public string CurrencyCode { get; set; }
        public string PayCashDeskId { get; set; }
        public int PayReferenceNum { get; set; }
        public string CustId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
