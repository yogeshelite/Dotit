using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImperCon
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int PerConId { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prname { get; set; }
        public string Func { get; set; }
        public string FaxNum { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNum { get; set; }
        public string PagerNum { get; set; }
        public string HomeNum { get; set; }
        public string AltNum { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Initials { get; set; }
        public string WebSite { get; set; }
        public string Im { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string FaceBook { get; set; }
        public string WebLink1 { get; set; }
        public string WebLink2 { get; set; }
        public string WebLink3 { get; set; }
        public string WebLink4 { get; set; }
        public string WebLink5 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string CorpName { get; set; }
        public string RoleCode { get; set; }
        public string Comment { get; set; }
        public string ContactTitle { get; set; }
        public string ReportsTo { get; set; }
        public string PrlastName { get; set; }
        public string PrfirstName { get; set; }
        public string PrmiddleName { get; set; }
        public string DcdUserId { get; set; }
        public string PhotoFile { get; set; }
        public bool GlobalPerCon { get; set; }
        public bool GlobalLock { get; set; }
        public bool Hcmlinked { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string IssuerPrsnIdcode { get; set; }
        public string IssuerIdtype { get; set; }
        public string IssuerName { get; set; }
        public string IssuerSurname { get; set; }
        public string IssuerSerialNum { get; set; }
        public DateTime? IssuerIdissDate { get; set; }
        public string ImageId { get; set; }
    }
}
