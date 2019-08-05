using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class VendBank
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string BankId { get; set; }
        public string BankName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public int CountryNum { get; set; }
        public string BankAcctNumber { get; set; }
        public string NameOnAccount { get; set; }
        public string SwiftNum { get; set; }
        public int Pmuid { get; set; }
        public string BankBranchCode { get; set; }
        public string Ibancode { get; set; }
        public string SecreditTransNum { get; set; }
        public string LegalName { get; set; }
        public string CorrespAccount { get; set; }
        public string LocalBic { get; set; }
        public string BankPersonCode { get; set; }
        public string VendAccountType { get; set; }
        public string CardCode { get; set; }
        public string BankGiroAcctNbr { get; set; }
        public string BankRefCode { get; set; }
        public bool AllowAsAltRemitToBank { get; set; }
        public string Dfiidentification { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Chdtaid { get; set; }
        public string ChisrpartyId { get; set; }
        public string FeeOwnership { get; set; }
        public string PobankAcctNum { get; set; }
        public string BankCustNum { get; set; }
        public int BankCustNumberStartPos { get; set; }
        public int BankCustNumberLen { get; set; }
        public string Baddress1 { get; set; }
        public string Baddress2 { get; set; }
        public string Baddress3 { get; set; }
        public string BankCharges { get; set; }
        public string BankCnstSymbol { get; set; }
        public string BankSpecSymbol { get; set; }
        public string BankType { get; set; }
        public string Bcity { get; set; }
        public int BcountryNum { get; set; }
        public string BpostalCode { get; set; }
        public string Bstate { get; set; }
        public string NochequeCode { get; set; }
        public string NofeeCostCode { get; set; }
        public string ReceiverName { get; set; }
        public string ReceivingBankName { get; set; }
        public string ReceivingBankNum { get; set; }
        public string ReceivingBranchName { get; set; }
        public string ReceivingBranchNum { get; set; }
        public string SebankFeeCostOwner { get; set; }
        public bool PedetractionsNba { get; set; }
        public string Mxsatcode { get; set; }
        public string MxsatnameShort { get; set; }
        public string MxsatnameFull { get; set; }
        public string DkcreditorNum { get; set; }
        public string PayId { get; set; }
        public string ClearSystemIdcode { get; set; }
        public string MemberId { get; set; }
    }
}
