using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprelecDp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int HeadNum { get; set; }
        public string EmpLink { get; set; }
        public string DeductionId { get; set; }
        public int DeductionNum { get; set; }
        public string GroupId { get; set; }
        public string EmpId { get; set; }
        public string SocSecNum { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public decimal DeductionAmt { get; set; }
        public DateTime? CheckDate { get; set; }
        public string Reference { get; set; }
        public string CoBankAcctId { get; set; }
        public string CoBankRoutingNum { get; set; }
        public int CoBankCheckDigit { get; set; }
        public string CoBankCompId { get; set; }
        public string CoBankName { get; set; }
        public string ServClassCode { get; set; }
        public string EntryClassCode { get; set; }
        public string EmpBankRoutingNum { get; set; }
        public string EmpBankAcctNum { get; set; }
        public string EmpBankAcctName { get; set; }
        public string EmpBankAcctType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
