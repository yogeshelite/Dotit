﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsPrepresse
    {
        public string Company { get; set; }
        public string RecId { get; set; }
        public string StdType { get; set; }
        public string OptionId { get; set; }
        public string PrepressId { get; set; }
        public string Source { get; set; }
        public string PrepressUserId { get; set; }
        public string Plant { get; set; }
        public string MfgItemUserId { get; set; }
        public string StdsDescription { get; set; }
        public string CustomerDesc { get; set; }
        public string MfgItemDescription { get; set; }
        public string PrepressDefDtlId { get; set; }
        public bool? TrueTmp { get; set; }
        public bool? FalseTmp { get; set; }
        public string EstimateId { get; set; }
        public string PlateId { get; set; }
        public string PartId { get; set; }
        public string ImpConcat { get; set; }
        public bool? IncludeScenario { get; set; }
        public string SourceDescription { get; set; }
        public bool? IncludeMatInStandard { get; set; }
        public bool? IncludeLaborInStandard { get; set; }
        public decimal? DeletedMatCostPerUnit { get; set; }
        public decimal? NumOfUnits { get; set; }
        public decimal? MatNumOfUnits { get; set; }
        public decimal? LaborAdjPct { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? ProdHr { get; set; }
        public int? NumOfBurns { get; set; }
        public string SequenceNumber { get; set; }
        public bool? Subcontracting { get; set; }
        public bool? SubcIsMatInPartsTbl { get; set; }
        public bool? SubcPrListPriority { get; set; }
        public int? SubcVendorNum { get; set; }
        public string SubcVendorId { get; set; }
        public string SubcVendorName { get; set; }
        public string SubcVendorContact { get; set; }
        public string SubcMatPartNum { get; set; }
        public string SubcMatPartDesc { get; set; }
        public bool? SubcPriceBexistForPart { get; set; }
        public string SubcBrowsePbui { get; set; }
        public string SubcPartUom { get; set; }
        public decimal? SubcUomcostPlist { get; set; }
        public decimal? SubcUomcostNoPlist { get; set; }
        public decimal? SubcEffectiveUnitCost { get; set; }
        public int? SubcDaysOut { get; set; }
        public string SubcCostSourceTexts { get; set; }
        public int? SubcPlistPricePer { get; set; }
        public decimal? NumUnitsPart { get; set; }
        public int? NumOfPages { get; set; }
        public decimal? NumUnitsPages { get; set; }
        public int? NumOfColor { get; set; }
        public decimal? NumUnitsColors { get; set; }
        public decimal? TmpPressShtsq { get; set; }
        public decimal? NumUnitsPshSqUn { get; set; }
        public decimal? NumUnitsLayouts { get; set; }
        public decimal? TmpLgqty { get; set; }
        public decimal? NumUnitsLg { get; set; }
        public decimal? NumUnitsPlates { get; set; }
        public decimal? TotalHr { get; set; }
        public string PartInventoryItemId { get; set; }
        public string ProdOperationId { get; set; }
        public string ProdOperationDesc { get; set; }
        public string OpComment { get; set; }
        public string SystemId { get; set; }
        public int? Qpos { get; set; }
        public decimal? LabMarkup { get; set; }
        public string MatMarkup { get; set; }
        public string VgtoDisplayUnderId { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgandMat { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public int? QtyOut { get; set; }
        public int? QtyIn { get; set; }
        public string ShowInRoutingOrMaterial { get; set; }
        public string MatPartIdui { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public string MatMfgComment { get; set; }
        public string MatPurchComment { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorName { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string MatCalcByUi { get; set; }
        public bool? IsOriginalPart { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public decimal? EstUomconvFactorToBase { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public string CostSourceTexts { get; set; }
        public bool? PrListPriorityForMatPart { get; set; }
        public bool? PriceBexistForMatPart { get; set; }
        public decimal? CostPlistForMatPart { get; set; }
        public decimal? PlistUmconvFactorToEstUm { get; set; }
        public decimal? CostPlistForMatPartEstUom { get; set; }
        public string BrowsePriceBreaksForMat { get; set; }
        public int? PlistPricePerForMatPart { get; set; }
        public string PressName { get; set; }
        public string MatBlname { get; set; }
        public string OperationBlname { get; set; }
        public string OpDtlBlname { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public string TopLevelUserId { get; set; }
        public string ConcatPrepsTemplates { get; set; }
        public string MatAnalysisCode { get; set; }
        public string MatAnalysisCodeDesc { get; set; }
        public string OpAnalysisCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public bool? MakeDirectUi { get; set; }
        public bool? MakeDirectApp { get; set; }
        public int? StdsDescriptionOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? MfgItemDescriptionOvrd { get; set; }
        public int? DeletedMatCostPerUnitOvrd { get; set; }
        public int? NumOfUnitsOvrd { get; set; }
        public int? MatNumOfUnitsOvrd { get; set; }
        public int? LaborAdjPctOvrd { get; set; }
        public int? LengthOvrd { get; set; }
        public int? WidthOvrd { get; set; }
        public int? SetupHrOvrd { get; set; }
        public int? ProdHrOvrd { get; set; }
        public int? SubcPrListPriorityOvrd { get; set; }
        public int? SubcVendorNumOvrd { get; set; }
        public int? SubcVendorContactOvrd { get; set; }
        public int? SubcMatPartNumOvrd { get; set; }
        public int? SubcMatPartDescOvrd { get; set; }
        public int? SubcUomcostPlistOvrd { get; set; }
        public int? SubcUomcostNoPlistOvrd { get; set; }
        public int? SubcEffectiveUnitCostOvrd { get; set; }
        public int? SubcDaysOutOvrd { get; set; }
        public int? PartInventoryItemIdOvrd { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? MatMfgCommentOvrd { get; set; }
        public int? MatPurchCommentOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? UomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? PrListPriorityForMatPartOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? MatAnalysisCodeDescOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeDescOvrd { get; set; }
        public int? MakeDirectUiOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string ProductionUnitCalcBasis { get; set; }
        public decimal? NumUnitsPerShtLength { get; set; }
        public decimal? NumUnitsPerShtWidth { get; set; }
        public decimal? NumUnitsFixedLength { get; set; }
        public decimal? NumUnitsFixedWidth { get; set; }
        public decimal? NumUnitsFpieceLength { get; set; }
        public decimal? NumUnitsFpieceWidth { get; set; }
        public string EstimateUserId { get; set; }
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

        public virtual EsMpoptions Option { get; set; }
        public virtual EsPrepress Prepress { get; set; }
    }
}