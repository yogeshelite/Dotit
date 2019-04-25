using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsInkemain
    {
        public EsInkemain()
        {
            EsInkelg = new HashSet<EsInkelg>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string InkId { get; set; }
        public string InkUserId { get; set; }
        public string InkDescUi { get; set; }
        public string CustomerDesc { get; set; }
        public string Plant { get; set; }
        public string StdType { get; set; }
        public string ProcessTypeId { get; set; }
        public string ProcessTypeUserId { get; set; }
        public bool? IsCoating { get; set; }
        public int? IsCoatingInt { get; set; }
        public string StockCategoryId { get; set; }
        public bool? IncludeScenario { get; set; }
        public string Side { get; set; }
        public string SideTmp { get; set; }
        public decimal? CoveragePctFrontUi { get; set; }
        public decimal? CoveragePctBackUi { get; set; }
        public bool? IsFrontOverallCoverage { get; set; }
        public bool? IsBackOverallCoverage { get; set; }
        public int? IsOverallCoverage { get; set; }
        public string PressId { get; set; }
        public string EstimateId { get; set; }
        public string PartId { get; set; }
        public string Createdby { get; set; }
        public DateTime? CreatedDate { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? MixHrPerUom { get; set; }
        public decimal? TotInkUnits { get; set; }
        public decimal? MixHr { get; set; }
        public decimal? TotalMainHr { get; set; }
        public string ProgName { get; set; }
        public string SequenceNumber { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public string SystemIdvendorData { get; set; }
        public int? NumOfInks { get; set; }
        public int? NumOfInksFront { get; set; }
        public int? NumOfInksBack { get; set; }
        public decimal? Mileage { get; set; }
        public decimal? MinUnitsLyt1Side { get; set; }
        public decimal? NumberUnitsFront { get; set; }
        public decimal? NumberUnitsBack { get; set; }
        public decimal? FountainSpoilUnits { get; set; }
        public decimal? TotalMatUnits { get; set; }
        public int? BlackWashup { get; set; }
        public int? SpotWashup { get; set; }
        public int? ProcessWashup { get; set; }
        public int? VarnishWashup { get; set; }
        public decimal? LaborMarkup { get; set; }
        public decimal? MatMarkup { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public string VgdisplayUnderMatTmp { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartIdui { get; set; }
        public string MatPartDesc { get; set; }
        public string MatMfgComment { get; set; }
        public string MatPurchComment { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string ProdOperationId { get; set; }
        public string ProdOperationDesc { get; set; }
        public string OpComment { get; set; }
        public bool? IsOriginalPart { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public string CostSourceTexts { get; set; }
        public string MatBlnameTop { get; set; }
        public string OperationBlnameTop { get; set; }
        public string OpDtlBlnameTop { get; set; }
        public bool? IncludeLabor { get; set; }
        public string InkMixDescription { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public string Source { get; set; }
        public bool? IsTop { get; set; }
        public bool? IsLg { get; set; }
        public bool? JdfisCayan { get; set; }
        public bool? JdfisMagenta { get; set; }
        public bool? JdfisYellow { get; set; }
        public bool? JdfisBlack { get; set; }
        public bool? JdfisOther { get; set; }
        public string TopLevelUserId { get; set; }
        public string MatAnalysisCode { get; set; }
        public string MatAnalysisCodeDesc { get; set; }
        public string OpAnalysisCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public string InkDtlId { get; set; }
        public string InkMileageId { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? MakeDirectUi { get; set; }
        public string MarkupLevels { get; set; }
        public string InkDescApp { get; set; }
        public decimal? CoveragePctFrontApp { get; set; }
        public decimal? CoveragePctBackApp { get; set; }
        public bool? MakeDirectApp { get; set; }
        public int? InkDescUiOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? CoveragePctFrontUiOvrd { get; set; }
        public int? CoveragePctBackUiOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? MixHrOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? NumOfInksOvrd { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartIduiOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? MatMfgCommentOvrd { get; set; }
        public int? MatPurchCommentOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? UomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? MatAnalysisCodeDescOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeDescOvrd { get; set; }
        public int? MakeDirectUiOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string EstimateUserId { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public string UserChar5 { get; set; }
        public string UserChar6 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public DateTime? UserDate5 { get; set; }
        public DateTime? UserDate6 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public decimal? UserDecimal9 { get; set; }
        public decimal? UserDecimal10 { get; set; }
        public decimal? UserDecimal11 { get; set; }
        public decimal? UserDecimal12 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }
        public int? UserInteger5 { get; set; }
        public int? UserInteger6 { get; set; }

        public virtual EsInk Ink { get; set; }
        public virtual EsInkdtl InkDtl { get; set; }
        public virtual EsInkmileage InkMileage { get; set; }
        public virtual EsMpoptions Option { get; set; }
        public virtual ICollection<EsInkelg> EsInkelg { get; set; }
    }
}
