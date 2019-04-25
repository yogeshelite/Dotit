using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbVendCnt
    {
        public string Company { get; set; }
        public int VendorNum { get; set; }
        public string PurPoint { get; set; }
        public int ConNum { get; set; }
        public string Name { get; set; }
        public string Func { get; set; }
        public string FaxNum { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAddress { get; set; }
        public string WebPassword { get; set; }
        public bool WebUser { get; set; }
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
        public string GlbCompany { get; set; }
        public int GlbVendorNum { get; set; }
        public string GlbPurPoint { get; set; }
        public int GlbConNum { get; set; }
        public bool GlobalLock { get; set; }
        public string OldCompany { get; set; }
        public int OldVendorNum { get; set; }
        public string OldPurPoint { get; set; }
        public int OldConNum { get; set; }
        public bool Skipped { get; set; }
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
        public Guid GlbSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
