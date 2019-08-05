﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsFinishing
    {
        public EsFinishing()
        {
            EsFinishe = new HashSet<EsFinishe>();
            EsFinishingdefaultsdtl = new HashSet<EsFinishingdefaultsdtl>();
            EsInlinefinish = new HashSet<EsInlinefinish>();
            EsPartfinishing = new HashSet<EsPartfinishing>();
            EsStdplant = new HashSet<EsStdplant>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string FinishingUserId { get; set; }
        public string FinishingDesc { get; set; }
        public bool? TmpTrue { get; set; }
        public string StdType { get; set; }
        public string StdTypeUserId { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? RfqentryAllow { get; set; }
        public bool? MatIncluded { get; set; }
        public bool? CreatePoreq { get; set; }
        public string CustomerDesc { get; set; }
        public string DeptId { get; set; }
        public string FinishingType { get; set; }
        public string CapacityUnit { get; set; }
        public string ProdUnitsCost { get; set; }
        public bool? IsCutOperation { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorDesc { get; set; }
        public int? VendorNumXdel { get; set; }
        public string ContactName { get; set; }
        public string MatCalcByCombo { get; set; }
        public string MatCalcByTmp { get; set; }
        public string MatCalcBy { get; set; }
        public decimal? MatUnitsPerProdUnit { get; set; }
        public string MatUnitsPerProdUnitLabel { get; set; }
        public string CalcMatAreaBy { get; set; }
        public bool? UseDimensions { get; set; }
        public string DimensionTypeCombo { get; set; }
        public string DimensionTypeTmp { get; set; }
        public string DimensionType { get; set; }
        public decimal? CostPer1ToN { get; set; }
        public decimal? CostPerInventoryMatUnit { get; set; }
        public int? Uomselected { get; set; }
        public int? CostSourceSelected { get; set; }
        public string CostSourceOptions { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string EstUom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public string CostSourceTexts { get; set; }
        public string UomoptionsCombo { get; set; }
        public string CostSourceTextsCombo { get; set; }
        public bool? TmpIsAreaRowRule { get; set; }
        public decimal? BaseSetupHr { get; set; }
        public string FinishInventoryItemDesc { get; set; }
        public bool? Inactive { get; set; }
        public decimal? CostPerProdunit { get; set; }
        public string ProdUnit { get; set; }
        public string ProdUnitTmp { get; set; }
        public string MultiplePart { get; set; }
        public string ApplyJobMarkup { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public bool? LaborIncluded { get; set; }
        public string StandardsMarkup { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public string HelperSchedResourceId { get; set; }
        public string WashupOperationId { get; set; }
        public string WashupOperationDesc { get; set; }
        public decimal? WashupHr { get; set; }
        public string LaborMarkupLevels { get; set; }
        public string LaborMarkupPercents { get; set; }
        public decimal? MinProdHr { get; set; }
        public decimal? BaseProdSpoilPctUi { get; set; }
        public decimal? BaseProdSpoilPct { get; set; }
        public int? SetupPieces { get; set; }
        public int? MinUnitsPerHr { get; set; }
        public int? AverageUnitsPerHr { get; set; }
        public int? MaxUnitsPerHr { get; set; }
        public bool? NotValidMinUnitsPerHr { get; set; }
        public bool? NotValidMaxUnitsPerHr { get; set; }
        public string CaliperSpoilAdjPct { get; set; }
        public string CaliperLaborAdjPct { get; set; }
        public string CaliperBreak { get; set; }
        public int? MaxNumOfPockets { get; set; }
        public bool? InvalidMaxNumOfPockets { get; set; }
        public int? PocketsPerOperator { get; set; }
        public int? PocketsPerHelper { get; set; }
        public decimal? SetupHrPerPocket { get; set; }
        public string AllowMultiplePasses { get; set; }
        public string PocketSetupSpoilAdjPct { get; set; }
        public string PocketSpoilAdjPct { get; set; }
        public string PocketLaborAdjPct { get; set; }
        public string PocketBreak { get; set; }
        public decimal? MaxUnitsPerContainer { get; set; }
        public string SystemId { get; set; }
        public string ProdLengthBreak { get; set; }
        public string ProdLengthSpoilAdjPct { get; set; }
        public string ProdLengthLaborAdjPct { get; set; }
        public bool? Rfeinclude { get; set; }
        public string Rfedesc { get; set; }
        public string SystemIdvendorData { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public decimal? MaxBindingTrim { get; set; }
        public string BindingStyle { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public string SubcPartNum { get; set; }
        public string SubcPartDesc { get; set; }
        public string SubcPartUom { get; set; }
        public bool? IsZeroSubcUomfactorToBase { get; set; }
        public int? SubcDaysOut { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public int? SubcCostSourceSelected { get; set; }
        public string SubcUomoptionsCombo { get; set; }
        public decimal? SubcCostPerEach { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public bool? IsInline { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public bool? AllowInCurPlantWash { get; set; }
        public bool? AllowProductionOfPartialPieces { get; set; }
        public int? BaseHelper1up { get; set; }
        public int? BaseHelper2up { get; set; }
        public int? IsBinding { get; set; }
        public int? IsPerfectBinding { get; set; }
        public decimal? Milling { get; set; }
        public decimal? MinHeadTrim { get; set; }
        public decimal? MaxHeadTrim { get; set; }
        public decimal? DefHeadTrim { get; set; }
        public decimal? MinFootTrim { get; set; }
        public decimal? MaxFootTrim { get; set; }
        public decimal? DefFootTrim { get; set; }
        public decimal? MinFaceTrim { get; set; }
        public decimal? MaxFaceTrim { get; set; }
        public decimal? DefFaceTrim { get; set; }
        public decimal? FrontLip { get; set; }
        public decimal? BackLip { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public string OpAnalysisCodeWash { get; set; }
        public bool? OpIsMissingAnalysCodeWash { get; set; }
        public string OpAnalysisCodeWashDesc { get; set; }
        public bool? ShowInRfq { get; set; }
        public decimal? MinBindFinSizeWidth { get; set; }
        public decimal? MaxBindFinSizeWidth { get; set; }
        public decimal? MinBindFinSizeLength { get; set; }
        public decimal? MaxBindFinSizeLength { get; set; }
        public decimal? MaxBindFeederScoreCaliper { get; set; }
        public int? BindStaticFeeders { get; set; }
        public int? BindMoveableFeeders { get; set; }
        public string BindMoveableInline { get; set; }
        public string BindMoveableInlineCombo { get; set; }
        public bool? BindFeedersUseFourPp { get; set; }
        public string BindFeeders { get; set; }
        public string E2jlaborPolicyIfTimeZero { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? VendorIdOvrd { get; set; }
        public int? ContactNameOvrd { get; set; }
        public int? EstUomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? SubcPartDescOvrd { get; set; }
        public int? SubcPartUomOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcCostPerEachOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeWashOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public decimal? MinSpineCaliper { get; set; }
        public decimal? MaxSpineCaliper { get; set; }
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
        public string BulkSpoilAdjPct { get; set; }
        public string BulkLaborAdjPct { get; set; }
        public string BulkBreak { get; set; }
        public decimal? MinCfunTrimUnfldWidth { get; set; }
        public decimal? MaxCfunTrimUnfldWidth { get; set; }
        public decimal? MinCfunTrimUnfldLength { get; set; }
        public decimal? MaxCfunTrimUnfldLength { get; set; }
        public string WidthBreak { get; set; }
        public string WidthLaborAdjPct { get; set; }
        public string WidthSpoilAdjPct { get; set; }
        public string LengthBreak { get; set; }
        public string LengthLaborAdjPct { get; set; }
        public string LengthSpoilAdjPct { get; set; }
        public decimal? LiftHeight { get; set; }
        public decimal? SecondsPerLift { get; set; }

        public virtual EsGroups Group { get; set; }
        public virtual EsStdtype StdTypeNavigation { get; set; }
        public virtual ICollection<EsFinishe> EsFinishe { get; set; }
        public virtual ICollection<EsFinishingdefaultsdtl> EsFinishingdefaultsdtl { get; set; }
        public virtual ICollection<EsInlinefinish> EsInlinefinish { get; set; }
        public virtual ICollection<EsPartfinishing> EsPartfinishing { get; set; }
        public virtual ICollection<EsStdplant> EsStdplant { get; set; }
    }
}
