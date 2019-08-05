using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcustMandate
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string MandateType { get; set; }
        public string MandateReference { get; set; }
        public int CustNum { get; set; }
        public string BankAcctId { get; set; }
        public string CreditorId { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string CreditorName { get; set; }
        public string CreditorAddress1 { get; set; }
        public string CreditorAddress2 { get; set; }
        public string CreditorAddress3 { get; set; }
        public string CreditorCity { get; set; }
        public string CreditorZip { get; set; }
        public int CreditorCountryNum { get; set; }
        public string CreditorRefPartyName { get; set; }
        public string CreditorRefPartyId { get; set; }
        public string DebtorName { get; set; }
        public string DebtorAddress1 { get; set; }
        public string DebtorAddress2 { get; set; }
        public string DebtorAddress3 { get; set; }
        public string DebtorCity { get; set; }
        public string DebtorZip { get; set; }
        public int DebtorCountryNum { get; set; }
        public string DebtorRefPartyName { get; set; }
        public string DebtorRefPartyId { get; set; }
        public string SignedPlace { get; set; }
        public string SignedBy { get; set; }
        public DateTime? SignedDate { get; set; }
        public string UndContractId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string PrintedBy { get; set; }
        public DateTime? PrintedDate { get; set; }
        public DateTime? FirstUseDate { get; set; }
        public DateTime? LastUseDate { get; set; }
        public string PaymentType { get; set; }
        public string Comment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string MandateStatus { get; set; }
    }
}
