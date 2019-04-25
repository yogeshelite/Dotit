using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcSegAccom
    {
        public string Company { get; set; }
        public int SegNum { get; set; }
        public string SegCd { get; set; }
        public string SegmentCode { get; set; }
        public string SegName { get; set; }
        public string SegDesc { get; set; }
        public int SegmentLevel { get; set; }
        public int ParentNum { get; set; }
        public string ParentCd { get; set; }
        public int ChildNum { get; set; }
        public string SegDisplayCd { get; set; }
        public bool IsAccom { get; set; }
        public int FacilityNum { get; set; }
        public int Seg1Id { get; set; }
        public string ResiType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostCd { get; set; }
        public int CountryNum { get; set; }
        public string Country { get; set; }
        public bool OverrideAddress { get; set; }
        public string AccTpCd { get; set; }
        public string AspTpCd { get; set; }
        public string Category { get; set; }
        public bool SegInactive { get; set; }
        public string InActRsnCd { get; set; }
        public int IsNonR { get; set; }
        public string Seg1Cd { get; set; }
        public string Seg2Cd { get; set; }
        public string Seg3Cd { get; set; }
        public string Seg4Cd { get; set; }
        public string Seg5Cd { get; set; }
        public string SegCtcd { get; set; }
        public string SegTpCd { get; set; }
        public string SegFsiteCd { get; set; }
        public string ImageName { get; set; }
        public string Logo { get; set; }
        public bool CareSystem { get; set; }
        public string TerritoryId { get; set; }
        public string Racsid { get; set; }
        public string Abn { get; set; }
        public DateTime? FirstCertDt { get; set; }
        public bool IsCert { get; set; }
        public DateTime? ExpiresOn { get; set; }
        public bool IsResp { get; set; }
        public bool IsSecrDmnt { get; set; }
        public decimal SegEsrmTpId { get; set; }
        public bool OnlineClaim { get; set; }
        public string MinorId { get; set; }
        public string ClassCode { get; set; }
        public string OrgType { get; set; }
        public bool FireSafety { get; set; }
        public bool PrivSpace { get; set; }
        public bool SyncAddress1 { get; set; }
        public bool SyncAddress2 { get; set; }
        public bool SyncAddress3 { get; set; }
        public bool SyncCity { get; set; }
        public bool SyncStateCd { get; set; }
        public bool SyncPostCd { get; set; }
        public bool SyncCountryNum { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string TaxId { get; set; }
        public DateTime? CompliantDt { get; set; }
        public string EmailAddress { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool SignificantRefurb { get; set; }
        public DateTime? SignificantRefurbDt { get; set; }
        public bool Contribution { get; set; }
        public string ClinicalSegCd { get; set; }
    }
}
