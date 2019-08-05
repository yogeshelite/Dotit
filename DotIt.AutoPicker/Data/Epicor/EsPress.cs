﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsPress
    {
        public EsPress()
        {
            EsInlinepress = new HashSet<EsInlinepress>();
            EsPressemain = new HashSet<EsPressemain>();
            EsPressfwebform = new HashSet<EsPressfwebform>();
            EsPressfwebfpsize = new HashSet<EsPressfwebfpsize>();
            EsScenariodefaultsdtl = new HashSet<EsScenariodefaultsdtl>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string PressUserId { get; set; }
        public string StdType { get; set; }
        public string StdTypeUserId { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public string SystemId { get; set; }
        public string PressDesc { get; set; }
        public string CustomerDesc { get; set; }
        public string PressType { get; set; }
        public string PressTypeUi { get; set; }
        public bool? IsWeb { get; set; }
        public bool? IsPerfctor { get; set; }
        public bool? Inactive { get; set; }
        public string DigitalOrOffset { get; set; }
        public bool? IsDigital { get; set; }
        public string ProcessTypeId { get; set; }
        public int? MaxNumOfCoatingUnits { get; set; }
        public string BlanketPrepareOperationId { get; set; }
        public string BlanketPrepareOperationDesc { get; set; }
        public decimal? BlanketPrepareProdHr { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public string WashupOperationId { get; set; }
        public string WashupOperationDesc { get; set; }
        public string DryingOperationId { get; set; }
        public string DryingOperationDesc { get; set; }
        public string ProofOutOperationId { get; set; }
        public string ProofOutOperationDesc { get; set; }
        public decimal? ProofOutProdHr { get; set; }
        public decimal? ProofOutSetupHr { get; set; }
        public string MarkupLevels { get; set; }
        public string MarkupPercents { get; set; }
        public decimal? MinProdHrPerLyt { get; set; }
        public decimal? MinPressSpeed { get; set; }
        public decimal? AveragePressSpeed { get; set; }
        public decimal? MaxPressSpeed { get; set; }
        public bool? NotValidMinUnitsPerHr { get; set; }
        public bool? NotValidMaxUnitsPerHr { get; set; }
        public int? MaxNumColors { get; set; }
        public bool? InvalidNumColors { get; set; }
        public decimal? GripperBlanketGap { get; set; }
        public decimal? ColorBarSize { get; set; }
        public string PlateId { get; set; }
        public string PlateUserId { get; set; }
        public decimal? MinSheetWidth { get; set; }
        public decimal? MaxSheetWidth { get; set; }
        public bool? InValidMinMaxSheetW { get; set; }
        public decimal? MinSheetLength { get; set; }
        public decimal? MaxSheetLength { get; set; }
        public bool? InValidMinMaxSheetL { get; set; }
        public decimal? MinSheetCaliper { get; set; }
        public decimal? MaxSheetCaliper { get; set; }
        public bool? ValidMinMaxCaliper { get; set; }
        public decimal? InkFountainSpoil { get; set; }
        public decimal? BaseProdSpoilPct { get; set; }
        public decimal? BaseProdSpoilPctUi { get; set; }
        public int? MaxPerfectingUnits { get; set; }
        public string CalcSpoilOnNet { get; set; }
        public decimal? SetupHrFirstLyt { get; set; }
        public decimal? SetupHrNextLyt { get; set; }
        public int? SetupShtsPlateChange { get; set; }
        public int? SetupShtsWorkTurnFlop { get; set; }
        public decimal? SetupHrOriginalPlate { get; set; }
        public decimal? SetupHrHangBlanket { get; set; }
        public decimal? SetupHrPlateChange { get; set; }
        public decimal? SetupHrWorkTurnFlop { get; set; }
        public decimal? BlackWashupHr { get; set; }
        public decimal? ProcessWashupHr { get; set; }
        public decimal? SpotWashupHr { get; set; }
        public decimal? VarnishWashupHr { get; set; }
        public string InkCoveragePctBreak { get; set; }
        public string InkSetupSheetAdjPct { get; set; }
        public string InkSetupLaborAdjPct { get; set; }
        public string InkProdSpoilAdjPct { get; set; }
        public string InkProdLaborAdjPct { get; set; }
        public string ProdLengthBreak { get; set; }
        public string ProdLengthSpoilAdjPct { get; set; }
        public string ProdLengthLaborAdjPct { get; set; }
        public string CaliperBreak { get; set; }
        public string CaliperSetupSheetAdjPct { get; set; }
        public string CaliperSetupLaborAdjPct { get; set; }
        public string CaliperProdSpoilAdjPct { get; set; }
        public string CaliperProdLaborAdjPct { get; set; }
        public decimal? OneColorSpoilAdjPct { get; set; }
        public decimal? TwoColorsSpoilAdjPct { get; set; }
        public decimal? ThreeColorsSpoilAdjPct { get; set; }
        public decimal? FourColorsSpoilAdjPct { get; set; }
        public decimal? AddlColorsSpoilAdjPct { get; set; }
        public decimal? OneColorLaborAdjPct { get; set; }
        public decimal? TwoColorsLaborAdjPct { get; set; }
        public decimal? ThreeColorsLaborAdjPct { get; set; }
        public decimal? FourColorsLaborAdjPct { get; set; }
        public decimal? AddlColorsLaborAdjPct { get; set; }
        public int? SetupShtsColor1Lyt1Front { get; set; }
        public int? SetupShtsColor2Lyt1Front { get; set; }
        public int? SetupShtsColor3Lyt1Front { get; set; }
        public int? SetupShtsColor4Lyt1Front { get; set; }
        public int? SetupShtsAddlColorLyt1Front { get; set; }
        public int? SetupShtsColor1Lyt1Back { get; set; }
        public int? SetupShtsColor2Lyt1Back { get; set; }
        public int? SetupShtsColor3Lyt1Back { get; set; }
        public int? SetupShtsColor4Lyt1Back { get; set; }
        public int? SetupShtsAddlColorLyt1Back { get; set; }
        public int? SetupShtsColor1NxtLytFront { get; set; }
        public int? SetupShtsColor2NxtLytFront { get; set; }
        public int? SetupShtsColor3NxtLytFront { get; set; }
        public int? SetupShtsColor4NxtLytFront { get; set; }
        public int? SetupShtsAddlColorNxtFmFront { get; set; }
        public int? SetupShtsColor1NxtLytBack { get; set; }
        public int? SetupShtsColor2NxtLytBack { get; set; }
        public int? SetupShtsColor3NxtLytBack { get; set; }
        public int? SetupShtsColor4NxtLytBack { get; set; }
        public int? SetupShtsAddlColorNxtFmBack { get; set; }
        public decimal? RegOpenSetupLaborAdjPct { get; set; }
        public decimal? RegAverageSetupLaborAdjPct { get; set; }
        public decimal? RegTightSetupLaborAdjPct { get; set; }
        public decimal? RegHairlineSetupLaborAdjPct { get; set; }
        public decimal? RegOpenSetupSheetAdjPct { get; set; }
        public decimal? RegAverageSetupSheetAdjPct { get; set; }
        public decimal? RegTightSetupSheetAdjPct { get; set; }
        public decimal? RegHairlineSetupSheetAdjPct { get; set; }
        public decimal? RegOpenProdLaborAdjPct { get; set; }
        public decimal? RegAverageProdLaborAdjPct { get; set; }
        public decimal? RegHairlineProdLaborAdjPct { get; set; }
        public decimal? RegTightProdLaborAdjPct { get; set; }
        public decimal? RegOpenProdSpoilAdjPct { get; set; }
        public decimal? RegAverageProdSpoilAdjPct { get; set; }
        public decimal? RegHairlineProdSpoilAdjPct { get; set; }
        public decimal? RegTightProdSpoilAdjPct { get; set; }
        public string Presscalcspeedby { get; set; }
        public decimal? SideMarginWebGuides { get; set; }
        public decimal? HeadFootmargin { get; set; }
        public string ProcessTypeUserId { get; set; }
        public bool? DigitalType { get; set; }
        public string PressWorkCenterDesc { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public decimal? MaxImagingWidthTmp { get; set; }
        public decimal? MaxImagingLengthTmp { get; set; }
        public decimal? MaxImagingWidthUi { get; set; }
        public decimal? MaxImagingLengthUi { get; set; }
        public decimal? MaxImagingWidth { get; set; }
        public decimal? MaxImagingLength { get; set; }
        public string VarTextBreak { get; set; }
        public string VarTxtSetupSheetAdjPct { get; set; }
        public string VarTxtSetupLaborAdjPct { get; set; }
        public string VarTxtProdSpoilAdjPct { get; set; }
        public string VarTxtProdLaborAdjPct { get; set; }
        public string VarPicBreak { get; set; }
        public string VarPicSetupSheetAdjPct { get; set; }
        public string VarPicSetupLaborAdjPct { get; set; }
        public string VarPicProdSpoilAdjPct { get; set; }
        public string VarPicProdLaborAdjPct { get; set; }
        public bool? ProcessInkOnlyPress { get; set; }
        public string DefProcessInkId { get; set; }
        public string PerfectingTurnUnit { get; set; }
        public int? ColorsAfterTurnUnit { get; set; }
        public int? ColorsAfterTurnUnitTmp { get; set; }
        public bool? IsColTurnUnitNeeded { get; set; }
        public bool? IsColTurnUnitWithinRange { get; set; }
        public decimal? MaxInkCoverUi { get; set; }
        public decimal? MaxInkCoverTmp { get; set; }
        public int? MaxRegLevel { get; set; }
        public int? NumOfWebs { get; set; }
        public decimal? WebCutOffs { get; set; }
        public decimal? CoreWaste { get; set; }
        public decimal? SlabWaste { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? IsWebTwoSides { get; set; }
        public string MeasureSpeedBy { get; set; }
        public bool? IsVarLength { get; set; }
        public bool? IsFwebAndNumOfWebs { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public bool? AllowInCurPlantWash { get; set; }
        public bool? AllowInCurPlantDry { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public string OpAnalysisCodeWash { get; set; }
        public bool? OpIsMissingAnalysCodeWash { get; set; }
        public string OpAnalysisCodeWashDesc { get; set; }
        public string OpAnalysisCodeDry { get; set; }
        public bool? OpIsMissingAnalysCodeDry { get; set; }
        public string OpAnalysisCodeDryDesc { get; set; }
        public string OpAnalysisCodeProofOut { get; set; }
        public bool? OpIsMissingAnalysCodeProofOut { get; set; }
        public string OpAnalysisCodeProofOutDesc { get; set; }
        public string OpAnalysisCodePrepareBlanket { get; set; }
        public bool? OpIsMissingAnalysCodePblanket { get; set; }
        public string OpAnalysisCodePrepareBlanketDesc { get; set; }
        public bool? TmpTrue { get; set; }
        public bool? IsCmykdefaultInkEmpty { get; set; }
        public bool? IsSheeterWebNoVarLength0 { get; set; }
        public bool? IsFwebVarLength { get; set; }
        public string InlinesList { get; set; }
        public string SpotcoatingInlineId { get; set; }
        public string OverallCoatingId { get; set; }
        public bool? ValidSameSpotOverallInline { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? MaxImagingWidthUiOvrd { get; set; }
        public int? MaxImagingLengthUiOvrd { get; set; }
        public int? IsWebTwoSidesOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string MeasureSpeedByUom { get; set; }
        public string MeasureSpeedPerUom { get; set; }
        public int? AveragePressSpeedOvrd { get; set; }
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

        public virtual EsInk DefProcessInk { get; set; }
        public virtual EsGroups Group { get; set; }
        public virtual EsPlate Plate { get; set; }
        public virtual EsStdtype StdTypeNavigation { get; set; }
        public virtual ICollection<EsInlinepress> EsInlinepress { get; set; }
        public virtual ICollection<EsPressemain> EsPressemain { get; set; }
        public virtual ICollection<EsPressfwebform> EsPressfwebform { get; set; }
        public virtual ICollection<EsPressfwebfpsize> EsPressfwebfpsize { get; set; }
        public virtual ICollection<EsScenariodefaultsdtl> EsScenariodefaultsdtl { get; set; }
    }
}
