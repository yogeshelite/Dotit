using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImapelecPy
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int HeadNum { get; set; }
        public int CheckNum { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal CheckAmt { get; set; }
        public decimal DocCheckAmt { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRate { get; set; }
        public string FromBankAcctId { get; set; }
        public string FromBankRoutingNum { get; set; }
        public int FromBankCheckDigit { get; set; }
        public string FromBankCompId { get; set; }
        public string FromBankName { get; set; }
        public string FromBankServClassCode { get; set; }
        public string FromBankEntryClassCode { get; set; }
        public int VendorNum { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorAddress3 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorPostalCode { get; set; }
        public string VendorCountry { get; set; }
        public int VendorCountryNum { get; set; }
        public string VendorAccountRef { get; set; }
        public string VendorBankId { get; set; }
        public string VendorBankName { get; set; }
        public string VendorBankNameOnAccount { get; set; }
        public string VendorBankAddress1 { get; set; }
        public string VendorBankAddress2 { get; set; }
        public string VendorBankAddress3 { get; set; }
        public string VendorBankCity { get; set; }
        public string VendorBankState { get; set; }
        public string VendorBankPostalCode { get; set; }
        public string VendorBankCountry { get; set; }
        public int VendorBankCountryNum { get; set; }
        public string VendorBankAcctNumber { get; set; }
        public string VendorBankSwiftNum { get; set; }
        public decimal Rpt1CheckAmt { get; set; }
        public decimal Rpt2CheckAmt { get; set; }
        public decimal Rpt3CheckAmt { get; set; }
        public string RateGrpCode { get; set; }
        public string PaymentNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
