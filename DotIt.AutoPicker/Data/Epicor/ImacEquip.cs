using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImacEquip
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
