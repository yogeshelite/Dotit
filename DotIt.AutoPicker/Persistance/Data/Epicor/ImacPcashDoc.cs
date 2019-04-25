using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacPcashDoc
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CashDeskId { get; set; }
        public int ReferenceNum { get; set; }
        public int PayMethodPmuid { get; set; }
        public string PayMethodName { get; set; }
        public string PayMethodReference { get; set; }
        public bool OnAccount { get; set; }
        public decimal ReceiptAmt { get; set; }
        public string Payee { get; set; }
        public string AccountNumber { get; set; }
        public string OtherDetails { get; set; }
        public decimal BankingTotalAmt { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
