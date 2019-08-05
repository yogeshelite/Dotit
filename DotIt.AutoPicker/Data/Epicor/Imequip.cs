using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imequip
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
        public string Plant { get; set; }
        public bool InActive { get; set; }
        public string Description { get; set; }
        public string StatusId { get; set; }
        public string Oem { get; set; }
        public string SerialNum { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime? InServiceDate { get; set; }
        public DateTime? WarrantyExpDate { get; set; }
        public string TypeId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public int SellingVendorNum { get; set; }
        public string SellingPurPoint { get; set; }
        public int ServiceVendorNum { get; set; }
        public string ServicePurPoint { get; set; }
        public string AssetNum { get; set; }
        public string Comments { get; set; }
        public string Specs { get; set; }
        public string MeterUom { get; set; }
        public int CurrentMeter { get; set; }
        public string ReadingComment { get; set; }
        public string LocId { get; set; }
        public string ParentEquipId { get; set; }
        public string LaborMeterOpt { get; set; }
        public DateTime? ReadingDate { get; set; }
        public int ReadingTime { get; set; }
        public string InspPlanPartNum { get; set; }
        public string SpecId { get; set; }
        public DateTime? LastCalDate { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecRevNum { get; set; }
        public string ProjectId { get; set; }
        public string UomclassId { get; set; }
        public string PhaseId { get; set; }
        public int PriorMeter { get; set; }
        public string Lineage { get; set; }
        public string TemplateJobNum { get; set; }
        public int AvgDailyUsage { get; set; }
        public bool GlobalEquip { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
