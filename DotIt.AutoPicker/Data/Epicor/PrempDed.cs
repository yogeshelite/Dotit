using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrempDed
    {
        public string Company { get; set; }
        public string EmpLink { get; set; }
        public string DeductionId { get; set; }
        public int DeductionNum { get; set; }
        public bool Period1 { get; set; }
        public bool Period2 { get; set; }
        public bool Period3 { get; set; }
        public bool Period4 { get; set; }
        public bool Period5 { get; set; }
        public decimal Rate { get; set; }
        public string RateQualifier { get; set; }
        public decimal DeclineOrigAmt { get; set; }
        public decimal DeclineRemAmt { get; set; }
        public decimal CheckLimit { get; set; }
        public decimal MonthLimit { get; set; }
        public decimal YearlyLimit { get; set; }
        public decimal CarryOverAmt { get; set; }
        public string ClassId { get; set; }
        public bool InActive { get; set; }
        public string Reference { get; set; }
        public string CommentText { get; set; }
        public string BankRoutingNum { get; set; }
        public string BankAcctNum { get; set; }
        public string BankAcctName { get; set; }
        public string BankAcctType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
