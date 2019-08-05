﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Resource
    {
        public string Company { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public bool Finite { get; set; }
        public bool AllowManualOverride { get; set; }
        public DateTime? NextMaintDate { get; set; }
        public string OutputWhse { get; set; }
        public string OutputBinNum { get; set; }
        public string BackflushWhse { get; set; }
        public string BackflushBinNum { get; set; }
        public string InputWhse { get; set; }
        public string InputBinNum { get; set; }
        public string ResourceType { get; set; }
        public decimal ConcurrentCapacity { get; set; }
        public bool TrackProdQty { get; set; }
        public string LinkedPart { get; set; }
        public string AssetNum { get; set; }
        public decimal ProdBurRate { get; set; }
        public decimal ProdLabRate { get; set; }
        public decimal SetupBurRate { get; set; }
        public decimal SetupLabRate { get; set; }
        public decimal QprodBurRate { get; set; }
        public decimal QprodLabRate { get; set; }
        public decimal QsetupBurRate { get; set; }
        public decimal QsetupLabRate { get; set; }
        public string QburdenType { get; set; }
        public bool GetDefaultBurdenFromGroup { get; set; }
        public int VendorNum { get; set; }
        public string BurdenType { get; set; }
        public string CalendarId { get; set; }
        public decimal MoveHours { get; set; }
        public decimal QueHours { get; set; }
        public bool GetDefaultMqfromGroup { get; set; }
        public bool InformOverload { get; set; }
        public decimal MinOverloadPerc { get; set; }
        public string OpCode { get; set; }
        public string OpStdId { get; set; }
        public bool GetDefaultLaborFromGroup { get; set; }
        public int FiniteHorizon { get; set; }
        public bool AutoMove { get; set; }
        public bool SplitOperations { get; set; }
        public decimal DailyProdQty { get; set; }
        public decimal BillLaborRate { get; set; }
        public decimal DailyProdRate { get; set; }
        public bool GetDefaultWhseFromGroup { get; set; }
        public bool Location { get; set; }
        public string InspPlanPartNum { get; set; }
        public string SpecId { get; set; }
        public DateTime? LastCalDate { get; set; }
        public string InspPlanRevNum { get; set; }
        public string SpecRevNum { get; set; }
        public string EquipId { get; set; }
        public string Url { get; set; }
        public string Jdfdevice { get; set; }
        public bool ExternalMes { get; set; }
        public decimal NumCavs { get; set; }
        public decimal RunnerWt { get; set; }
        public int SetupTime { get; set; }
        public int TearDownTime { get; set; }
        public string MiscInfo1 { get; set; }
        public string MiscInfo2 { get; set; }
        public string Brand { get; set; }
        public string LocId { get; set; }
        public int PmMapNo { get; set; }
        public string SetupUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool MobileResource { get; set; }
        public bool ExternalMessyncRequired { get; set; }
        public DateTime? ExternalMeslastSync { get; set; }
        public bool Mesqueue { get; set; }
    }
}
