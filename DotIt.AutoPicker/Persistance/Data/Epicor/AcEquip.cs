using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AcEquip
    {
        public string Company { get; set; }
        public string EquipId { get; set; }
        public int CustNum { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ScheduledToDate { get; set; }
        public string Manager { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string ServiceType { get; set; }
        public string PrefResourceGrpId { get; set; }
        public string PrefResourceId { get; set; }
        public string TaskSetId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
    }
}
