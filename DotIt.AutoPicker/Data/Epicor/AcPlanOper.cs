using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AcPlanOper
    {
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int PlanNum { get; set; }
        public int OprSeq { get; set; }
        public string OpCode { get; set; }
        public string Opdesc { get; set; }
        public bool SubContract { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int VendorNum { get; set; }
        public string Otscontact { get; set; }
        public string Otsname { get; set; }
        public string Otsaddress1 { get; set; }
        public string Otsaddress2 { get; set; }
        public string Otsaddress3 { get; set; }
        public string Otscity { get; set; }
        public string Otsstate { get; set; }
        public string Otszip { get; set; }
        public string OtsphoneNum { get; set; }
        public string OtsfaxNum { get; set; }
        public string OtsresaleId { get; set; }
        public int OtscountryNum { get; set; }
        public string OtstaxRegionCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public string TaskSetId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
