using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbCustCnt
    {
        public string Company { get; set; }
        public int CustNum { get; set; }
        public string ShipToNum { get; set; }
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
        public string SfportalPassword { get; set; }
        public bool Sfuser { get; set; }
        public bool PortalUser { get; set; }
        public string RoleCode { get; set; }
        public string CellPhoneNum { get; set; }
        public string PagerNum { get; set; }
        public string HomeNum { get; set; }
        public string AltNum { get; set; }
        public string ContactTitle { get; set; }
        public string ReportsTo { get; set; }
        public string Comment { get; set; }
        public bool NoContact { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateDcdUserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public string ChangeDcdUserId { get; set; }
        public bool Inactive { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Initials { get; set; }
        public string ExternalId { get; set; }
        public int GlbCustNum { get; set; }
        public string GlbCompany { get; set; }
        public string GlbShipToNum { get; set; }
        public int GlbConNum { get; set; }
        public bool GlobalLock { get; set; }
        public string OldCompany { get; set; }
        public int OldCustNum { get; set; }
        public string OldShipToNum { get; set; }
        public int OldConNum { get; set; }
        public bool ShowInputPrice { get; set; }
        public bool Skipped { get; set; }
        public string ChangedBy { get; set; }
        public int ChangeTime { get; set; }
        public int MasterConNum { get; set; }
        public int MasterCustNum { get; set; }
        public string MasterShipToNum { get; set; }
        public string FaceBook { get; set; }
        public string Im { get; set; }
        public string LinkedIn { get; set; }
        public int PerConId { get; set; }
        public bool SyncAddressToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public bool SyncLinksToPerCon { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncPhoneToPerCon { get; set; }
        public string Twitter { get; set; }
        public string WebLink1 { get; set; }
        public string WebLink2 { get; set; }
        public string WebLink3 { get; set; }
        public string WebLink4 { get; set; }
        public string WebLink5 { get; set; }
        public string WebSite { get; set; }
        public bool PerConAddress { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SyncToExternalCrm { get; set; }
        public string ExternalCrmcustomerId { get; set; }
        public string ExternalCrmcontactId { get; set; }
    }
}
