using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imarmovement
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TranType { get; set; }
        public int HeadNum { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceRef { get; set; }
        public string TranRef { get; set; }
        public int MovementNum { get; set; }
        public DateTime? TranDate { get; set; }
        public int CustNum { get; set; }
        public string LegalNum { get; set; }
        public string TranLegalNumber { get; set; }
        public string CurrencyCode { get; set; }
        public decimal TranAmt { get; set; }
        public decimal DocTranAmt { get; set; }
        public decimal Rpt1TranAmt { get; set; }
        public decimal Rpt2TranAmt { get; set; }
        public decimal Rpt3TranAmt { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string Subledger { get; set; }
        public string GainLossType { get; set; }
        public bool Posted { get; set; }
        public bool BalUpdated { get; set; }
        public DateTime CreateDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
