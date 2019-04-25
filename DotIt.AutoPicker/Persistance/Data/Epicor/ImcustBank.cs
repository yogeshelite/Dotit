using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImcustBank
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankAcctNumber { get; set; }
        public string BankIdentifier { get; set; }
        public bool PrimaryBank { get; set; }
        public string NameOnAccount { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int Country { get; set; }
        public string BankBranchCode { get; set; }
        public string Ibancode { get; set; }
        public int Pmuid { get; set; }
        public string LegalName { get; set; }
        public string AgreeRef { get; set; }
        public string CorrespAccount { get; set; }
        public DateTime? AgreeExpDate { get; set; }
        public string LocalBic { get; set; }
        public string BankPersonCode { get; set; }
        public bool AllowAsAltRemitToBank { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string TransPersonName { get; set; }
        public string TransPersonName2 { get; set; }
        public string TransPersonName3 { get; set; }
        public string TransPersonName4 { get; set; }
        public string TransPersonName5 { get; set; }
        public string Mxrfc { get; set; }
        public string Mxsatcode { get; set; }
    }
}
