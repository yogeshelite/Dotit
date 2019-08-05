using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SalesRep
    {
        public bool InActive { get; set; }
        public string Company { get; set; }
        public string SalesRepCode { get; set; }
        public string Name { get; set; }
        public decimal CommissionPercent { get; set; }
        public bool CommissionEarnedAt { get; set; }
        public bool AlertFlag { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int CountryNum { get; set; }
        public string OfficePhoneNum { get; set; }
        public string FaxPhoneNum { get; set; }
        public string CellPhoneNum { get; set; }
        public string PagerNum { get; set; }
        public string HomePhoneNum { get; set; }
        public string EmailAddress { get; set; }
        public string SalesRepTitle { get; set; }
        public string RepReportsTo { get; set; }
        public string Comment { get; set; }
        public int SalesMgrConfidence { get; set; }
        public string RoleCode { get; set; }
        public bool ViewAllTer { get; set; }
        public bool ViewCompPipe { get; set; }
        public bool WebSaleGetsCommission { get; set; }
        public string CnvEmpId { get; set; }
        public int PerConId { get; set; }
        public bool SyncNameToPerCon { get; set; }
        public bool SyncAddressToPerCon { get; set; }
        public bool SyncPhoneToPerCon { get; set; }
        public bool SyncEmailToPerCon { get; set; }
        public bool SyncLinksToPerCon { get; set; }
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
        public int MgrWorstCsPct { get; set; }
        public int MgrBestCsPct { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool WebSalesRep { get; set; }
        public string EccsalesRepCode { get; set; }
    }
}
