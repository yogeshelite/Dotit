using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcustCntImport
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public long ParentImportId { get; set; }
        public long ImportId { get; set; }
        public int CustNum { get; set; }
        public int ConNum { get; set; }
        public string Name { get; set; }
        public string Func { get; set; }
        public string FaxNum { get; set; }
        public string PhoneNum { get; set; }
        public bool SpecialAddress { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string CorpName { get; set; }
        public string EmailAddress { get; set; }
        public int CountryNum { get; set; }
        public string RoleCode { get; set; }
        public string CellPhoneNum { get; set; }
        public string PagerNum { get; set; }
        public string HomeNum { get; set; }
        public string AltNum { get; set; }
        public string ContactTitle { get; set; }
        public bool NoContact { get; set; }
        public int MatchedCustNum { get; set; }
        public int MatchedConNum { get; set; }
        public string MatchedFlag { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Initials { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
