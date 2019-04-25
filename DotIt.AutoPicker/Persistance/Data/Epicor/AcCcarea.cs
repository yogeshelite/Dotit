using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcCcarea
    {
        public string Company { get; set; }
        public int AreaId { get; set; }
        public string AreaCd { get; set; }
        public string AreaDesc { get; set; }
        public string Manager { get; set; }
        public string Admin { get; set; }
        public bool OnlineClaim { get; set; }
        public string ProviderNo { get; set; }
        public string MinorId { get; set; }
        public string OrgType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int CountryNum { get; set; }
        public string Country { get; set; }
        public string SegFsiteCd { get; set; }
        public string TerritoryId { get; set; }
        public string PhoneNum { get; set; }
        public string FaxNum { get; set; }
        public string EmailAddress { get; set; }
        public string TaxId { get; set; }
        public string ImageName { get; set; }
        public string Logo { get; set; }
        public string Comments { get; set; }
        public DateTime? CompliantDate { get; set; }
        public DateTime? LastSchedDate { get; set; }
        public bool Inactive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
