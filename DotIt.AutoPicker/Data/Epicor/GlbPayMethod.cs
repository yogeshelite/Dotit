using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPayMethod
    {
        public bool AutoBankRec { get; set; }
        public string Company { get; set; }
        public string DefPayCode { get; set; }
        public int EftheadUid { get; set; }
        public bool Inactive { get; set; }
        public string Name { get; set; }
        public bool OnlyBankCurr { get; set; }
        public string OutputFile { get; set; }
        public decimal OverPayPct { get; set; }
        public bool Piapprove { get; set; }
        public int PigenMethod { get; set; }
        public string Pitype { get; set; }
        public int Pmsource { get; set; }
        public int Pmuid { get; set; }
        public string RegNum { get; set; }
        public bool Reimbursable { get; set; }
        public bool RequireBank { get; set; }
        public string SenderRef { get; set; }
        public bool SummarizePerCustomer { get; set; }
        public bool Test { get; set; }
        public int Type { get; set; }
        public decimal UnderPayPct { get; set; }
        public string GlbCompany { get; set; }
        public int GlbPmuid { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalPayMethod { get; set; }
        public string CardCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int DepositSlips { get; set; }
        public bool IsPositiveBalance { get; set; }
        public int Apgrouping { get; set; }
        public bool Apidgeneration { get; set; }
        public int Argrouping { get; set; }
        public bool Aridgeneration { get; set; }
        public int Aridtiming { get; set; }
        public string EftdebitMemoHandlingCode { get; set; }
        public DateTime? EftdebitMemoDueDate { get; set; }
        public DateTime? EftproductNumDate { get; set; }
        public int EftproductNumber { get; set; }
        public bool Sepo3payment { get; set; }
        public string SecrossBrdPayMethod { get; set; }
        public string SecurrPocket { get; set; }
        public string SeerrorHandling { get; set; }
        public string SeuseIban { get; set; }
        public string Sepath { get; set; }
        public bool SecreateErrorLog { get; set; }
        public bool SefileForEachPayCurr { get; set; }
        public bool NopaymentList { get; set; }
        public bool NotelepayPayment { get; set; }
        public bool NotelepayReply { get; set; }
        public string DefeeRule { get; set; }
        public int DeserialNum { get; set; }
        public string DestateNum { get; set; }
        public DateTime? DelastUseDate { get; set; }
        public string MxpaidAs { get; set; }
        public int MxpaymentNum { get; set; }
        public int MxtotalPayments { get; set; }
        public int MxpaymentType { get; set; }
        public string Mxsatcode { get; set; }
        public string Mxsatdesc { get; set; }
        public bool PymtProposal { get; set; }
        public bool AutoCheckNum { get; set; }
        public bool EnterPymtTotal { get; set; }
        public int CheckNumSeq { get; set; }
        public string Us1099ktranType { get; set; }
        public decimal Us1099kamtThreshold { get; set; }
        public int Us1099ktranThreshold { get; set; }
    }
}
