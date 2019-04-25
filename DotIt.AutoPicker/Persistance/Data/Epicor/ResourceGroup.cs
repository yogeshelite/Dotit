using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ResourceGroup
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string ResourceGrpId { get; set; }
        public string Description { get; set; }
        public string CalendarId { get; set; }
        public bool Inactive { get; set; }
        public bool AllowManualOverride { get; set; }
        public int FiniteHorizon { get; set; }
        public int NumberOfMachines { get; set; }
        public int SchMachine { get; set; }
        public string BurdenType { get; set; }
        public decimal MoveHours { get; set; }
        public string Jcdept { get; set; }
        public decimal QueHours { get; set; }
        public string OpCode { get; set; }
        public decimal ProdBurRate { get; set; }
        public decimal ProdLabRate { get; set; }
        public decimal SetupBurRate { get; set; }
        public decimal SetupLabRate { get; set; }
        public decimal QprodBurRate { get; set; }
        public decimal QprodLabRate { get; set; }
        public decimal QsetupBurRate { get; set; }
        public decimal QsetupLabRate { get; set; }
        public bool SplitBurden { get; set; }
        public decimal ProdCrewSize { get; set; }
        public decimal SetupCrewSize { get; set; }
        public string OpStdId { get; set; }
        public int ReloadNum { get; set; }
        public string ReloadStatus { get; set; }
        public decimal DailyCapacity1 { get; set; }
        public decimal DailyCapacity2 { get; set; }
        public decimal DailyCapacity3 { get; set; }
        public decimal DailyCapacity4 { get; set; }
        public decimal DailyCapacity5 { get; set; }
        public decimal DailyCapacity6 { get; set; }
        public decimal DailyCapacity7 { get; set; }
        public string QburdenType { get; set; }
        public bool BurdenEqlabor { get; set; }
        public bool SplitOperations { get; set; }
        public string ResourceType { get; set; }
        public string InputWhse { get; set; }
        public string InputBinNum { get; set; }
        public string OutputWhse { get; set; }
        public string OutputBinNum { get; set; }
        public string BackflushWhse { get; set; }
        public string BackflushBinNum { get; set; }
        public bool InformOverload { get; set; }
        public decimal MinOverloadPerc { get; set; }
        public string BackflushEmpId { get; set; }
        public bool SubContract { get; set; }
        public bool AutoMove { get; set; }
        public bool UseEstimates { get; set; }
        public decimal DailyProdQty { get; set; }
        public decimal BillLaborRate { get; set; }
        public decimal DailyProdRate { get; set; }
        public bool Location { get; set; }
        public bool DistributeLoad { get; set; }
        public bool TrkProdAct { get; set; }
        public bool SetShopLoad { get; set; }
        public decimal Taktvalue { get; set; }
        public bool UseCalendarForMove { get; set; }
        public bool UseCalendarForQueue { get; set; }
        public string Url { get; set; }
        public string Jdfdevice { get; set; }
        public string Jdfoperation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ExternalMes { get; set; }
        public bool Mesqueue { get; set; }
    }
}
