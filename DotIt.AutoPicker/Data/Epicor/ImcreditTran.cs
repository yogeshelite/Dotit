using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcreditTran
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public DateTime? TranDate { get; set; }
        public int TranTime { get; set; }
        public int TranNum { get; set; }
        public string TranType { get; set; }
        public decimal TranTotal { get; set; }
        public decimal DocTranTotal { get; set; }
        public string Pnref { get; set; }
        public string AuthCode { get; set; }
        public string Result { get; set; }
        public string ResponseMsg { get; set; }
        public string Avsaddr { get; set; }
        public string Avszip { get; set; }
        public string Cscmatch { get; set; }
        public int OrderNum { get; set; }
        public int InvoiceNum { get; set; }
        public int HeadNum { get; set; }
        public string CardType { get; set; }
        public string CurrencyCode { get; set; }
        public string TranTypeDesc { get; set; }
        public string CardMemberName { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public string CardmemberReference { get; set; }
        public string CardNumber { get; set; }
        public string StAddress { get; set; }
        public string Zip { get; set; }
        public string ReferencePnref { get; set; }
        public bool AuthUsed { get; set; }
        public string CardStore { get; set; }
        public decimal Freight { get; set; }
        public decimal DocFreight { get; set; }
        public decimal Tax { get; set; }
        public decimal DocTax { get; set; }
        public decimal Amount { get; set; }
        public decimal DocAmount { get; set; }
        public int CustNum { get; set; }
        public decimal Rpt1Amount { get; set; }
        public decimal Rpt2Amount { get; set; }
        public decimal Rpt3Amount { get; set; }
        public decimal Rpt1Freight { get; set; }
        public decimal Rpt2Freight { get; set; }
        public decimal Rpt3Freight { get; set; }
        public decimal Rpt1Tax { get; set; }
        public decimal Rpt2Tax { get; set; }
        public decimal Rpt3Tax { get; set; }
        public decimal Rpt1TranTotal { get; set; }
        public decimal Rpt2TranTotal { get; set; }
        public decimal Rpt3TranTotal { get; set; }
        public string CreatedBy { get; set; }
        public string StrId { get; set; }
        public int Cvncode { get; set; }
        public string Cvnmessage { get; set; }
        public string ReferrerCode { get; set; }
        public string PtorderNum { get; set; }
        public string AuthEntity { get; set; }
        public bool TranSuccess { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Cccity { get; set; }
        public string Ccstate { get; set; }
        public string FdmsreferenceData { get; set; }
        public string Processor { get; set; }
        public string IsocurrCode { get; set; }
    }
}
