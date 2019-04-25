using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsMpoptions
    {
        public EsMpoptions()
        {
            EsEstimatematerial = new HashSet<EsEstimatematerial>();
            EsEstimateoperations = new HashSet<EsEstimateoperations>();
            EsFinishe = new HashSet<EsFinishe>();
            EsFoldingelg = new HashSet<EsFoldingelg>();
            EsFoldingemain = new HashSet<EsFoldingemain>();
            EsImplg = new HashSet<EsImplg>();
            EsImpmain = new HashSet<EsImpmain>();
            EsInkelg = new HashSet<EsInkelg>();
            EsInkemain = new HashSet<EsInkemain>();
            EsInlinee = new HashSet<EsInlinee>();
            EsPlatee = new HashSet<EsPlatee>();
            EsPostcutelg = new HashSet<EsPostcutelg>();
            EsPostcutemain = new HashSet<EsPostcutemain>();
            EsPrecute = new HashSet<EsPrecute>();
            EsPrepresse = new HashSet<EsPrepresse>();
            EsPresselg = new HashSet<EsPresselg>();
            EsPressemain = new HashSet<EsPressemain>();
            EsStockeform = new HashSet<EsStockeform>();
            EsStockelg = new HashSet<EsStockelg>();
            EsStockemain = new HashSet<EsStockemain>();
        }

        public string RecId { get; set; }
        public string PartId { get; set; }
        public string EstimateId { get; set; }
        public string EstimateUserId { get; set; }
        public string EstQtyId { get; set; }
        public string EstPrefsId { get; set; }
        public bool? WizardScenarioOrQty { get; set; }
        public bool? IncludeScenario { get; set; }
        public bool? OptionSelected { get; set; }
        public bool? MfgplanOption { get; set; }
        public bool? IsFirst3Scenarios { get; set; }
        public decimal? Qty { get; set; }
        public int? OptionPosition { get; set; }
        public int? QtyPosition { get; set; }
        public int? QtyPositionIndex { get; set; }
        public string ScenarioDefaultId { get; set; }
        public int? PartType { get; set; }
        public string PressId { get; set; }
        public string PressUserId { get; set; }
        public string ProcessTypeId { get; set; }
        public bool? DigitalType { get; set; }
        public string StockIdwiz { get; set; }
        public string StockIdmfg { get; set; }
        public string StockId { get; set; }
        public string StockcategoryId { get; set; }
        public string StockUserId { get; set; }
        public string PrepressDefaultsId { get; set; }
        public string PrepressDefaultsUserId { get; set; }
        public string PrepressDefaultsDesc { get; set; }
        public string PlateId { get; set; }
        public string PlateUserId { get; set; }
        public string PrepressCutterId { get; set; }
        public string PrepressCutterUserId { get; set; }
        public string PostpressCutterId { get; set; }
        public string PostpressCutterUserId { get; set; }
        public string FolderId { get; set; }
        public string FoldingUserId { get; set; }
        public decimal? GripperGapAllowance { get; set; }
        public bool? CalcNeeded { get; set; }
        public bool? InitializationDone { get; set; }
        public decimal? SideMargin { get; set; }
        public decimal? HeadFootMargin { get; set; }
        public decimal? JdfuomlengthFactor { get; set; }
        public string JdfpartDescWiz { get; set; }
        public string JdfpartDescMfg { get; set; }
        public string JdfpartDesc { get; set; }
        public int? BindingStyleWiz { get; set; }
        public string BindingStyleWizCombo { get; set; }
        public int? BindingStyleMfg { get; set; }
        public string BindingStyleMfgCombo { get; set; }
        public string BindingStyleCombo { get; set; }
        public int? BindingStyle { get; set; }
        public string BindingStyleUi { get; set; }
        public int? FlatPiecesMultWiz { get; set; }
        public int? FlatPiecesMultMfg { get; set; }
        public int? FlatPiecesMult { get; set; }
        public int? NumFoldsRightWiz { get; set; }
        public int? NumFoldsRightMfg { get; set; }
        public int? NumFoldsRight { get; set; }
        public int? NumFoldsParallelWiz { get; set; }
        public int? NumFoldsParallelMfg { get; set; }
        public int? NumFoldsParallel { get; set; }
        public decimal? FinishedWidthWiz { get; set; }
        public decimal? FinishedWidthMfg { get; set; }
        public decimal? FinishedWidth { get; set; }
        public decimal? FinishedLengthWiz { get; set; }
        public decimal? FinishedLengthMfg { get; set; }
        public decimal? FinishedLength { get; set; }
        public decimal? OpenWidthWiz { get; set; }
        public decimal? OpenWidthMfg { get; set; }
        public decimal? OpenWidthFinPart { get; set; }
        public decimal? OpenSizeSwitch { get; set; }
        public decimal? OpenWidth { get; set; }
        public decimal? OpenLengthWiz { get; set; }
        public decimal? OpenLengthMfg { get; set; }
        public decimal? OpenWidthLengthPart { get; set; }
        public decimal? OpenLength { get; set; }
        public decimal? FinishedPieceWidth { get; set; }
        public decimal? FinishedPieceLength { get; set; }
        public int? PagesWiz { get; set; }
        public int? PagesMfg { get; set; }
        public int? Pages { get; set; }
        public int? PagesIncFworkMult { get; set; }
        public int? PagesForImpAlgo { get; set; }
        public decimal? AvgStockCaliper { get; set; }
        public decimal? SumFpieceVolume { get; set; }
        public decimal? SumPartThickness { get; set; }
        public decimal? SumPartWeight { get; set; }
        public string GrainDirectionWiz { get; set; }
        public string GrainDirectionMfg { get; set; }
        public string GrainDirection { get; set; }
        public string StockAddlCommentsWiz { get; set; }
        public string StockAddlCommentsMfg { get; set; }
        public string StockAddlComments { get; set; }
        public bool? CustSuppliedStockWiz { get; set; }
        public bool? CustSuppliedStockMfg { get; set; }
        public bool? CustSuppliedStock { get; set; }
        public int? WorkingPieceType { get; set; }
        public decimal? BleedSizeWiz { get; set; }
        public decimal? BleedSizeMfg { get; set; }
        public decimal? BleedSize { get; set; }
        public decimal? WorkingPieceWidth { get; set; }
        public decimal? WorkingPieceLength { get; set; }
        public decimal? WebPressCutOff { get; set; }
        public string FinishingDefaultsId { get; set; }
        public string FinishingDefaultsName { get; set; }
        public string FinishingDefaultsDesc { get; set; }
        public string PressProdOperId { get; set; }
        public decimal? OperTotalHr { get; set; }
        public decimal? MatStdMarkup { get; set; }
        public decimal? MatCostNoMarkup { get; set; }
        public decimal? MatCostStdMarkup { get; set; }
        public decimal? MatRelativePrice { get; set; }
        public decimal? MatStdMarkupOnly { get; set; }
        public decimal? MarginalMatCost { get; set; }
        public decimal? LaborStdMarkup { get; set; }
        public decimal? LaborCostNoMarkup { get; set; }
        public decimal? LaborCostStdMarkup { get; set; }
        public decimal? LaborRelativePrice { get; set; }
        public decimal? LaborStdMarkupOnly { get; set; }
        public decimal? MarginalOperCost { get; set; }
        public decimal? SubcStdMarkup { get; set; }
        public decimal? SubcCostNoMarkup { get; set; }
        public decimal? SubcCostStdMarkup { get; set; }
        public decimal? SubcRelativePrice { get; set; }
        public decimal? SubcStdMarkupOnly { get; set; }
        public decimal? TotalMfgPlanCostNoMarkup { get; set; }
        public decimal? TotalMfgPlanCostStdMarkup { get; set; }
        public decimal? TotalStdMarkupOnly { get; set; }
        public decimal? TotalMfgPlanRalativePrice { get; set; }
        public decimal? TotalStdMarkupPct { get; set; }
        public decimal? MfgValueAdded { get; set; }
        public decimal? MfgValueAddedPct { get; set; }
        public decimal? CostPer1000Units { get; set; }
        public int? QuoteNum { get; set; }
        public string OptionPositionDescTemp { get; set; }
        public string OptionPressDescWizard { get; set; }
        public string PressUserIdforUi { get; set; }
        public string UiheaderTemp { get; set; }
        public decimal? ColorBarSize { get; set; }
        public string PressSetupAdjModifies { get; set; }
        public decimal? RoundToShts { get; set; }
        public string ParentId { get; set; }
        public bool? IsTopPart { get; set; }
        public bool? ProcessInkOnlyMachine { get; set; }
        public string DefProcessInkId { get; set; }
        public bool? MfgShouldBeInPlace { get; set; }
        public bool? NoFoldingErec { get; set; }
        public bool? NoFoldErecInSeorMfg { get; set; }
        public int? ErrorsInPrepressRecords { get; set; }
        public int? ErrorsInPlatesRecords { get; set; }
        public int? ErrorsInInkRecords { get; set; }
        public int? ErrorssInStockRecords { get; set; }
        public int? ErrorsInPrePressCutRecords { get; set; }
        public int? ErrorsInPressOrImpRecords { get; set; }
        public int? ErrorsInPostPressCutRecords { get; set; }
        public int? ErrorsInFoldingRecords { get; set; }
        public int? ErrorsInFinishingRecords { get; set; }
        public int? ErrorsInInlineRecords { get; set; }
        public int? ErrorsInOption { get; set; }
        public int? ErrorsStopAtSd { get; set; }
        public bool? UseBlresultsMatrix { get; set; }
        public int? StockShtsQin1st { get; set; }
        public int? QtyIn1st { get; set; }
        public bool? UseCutterAsTrimmer { get; set; }
        public bool? TmpIsCalcNoPagsPerPart { get; set; }
        public bool? TmpIsCalcNumOfColorPerPart { get; set; }
        public bool? TmpIsCalcPresStSizePerPart { get; set; }
        public bool? TmpIsCalcNumOfLytsPerPart { get; set; }
        public bool? TmpIsCalcLgqtyPerPart { get; set; }
        public bool? TmpIsCalcNumPlatePerPart { get; set; }
        public bool? TmpIsCalcFinPicSizPerPart { get; set; }
        public string PressIdtmp { get; set; }
        public bool? UseInterpolation { get; set; }
        public string QtyDesc { get; set; }
        public decimal? UtilizationWarnningLimit { get; set; }
        public decimal? UtilizationErrorLimit { get; set; }
        public decimal? UseCutterAsTrimmerThreshold { get; set; }
        public string JdflengthUm { get; set; }
        public string Jdfarea { get; set; }
        public string SheetsUm { get; set; }
        public string JdfvolumeUm { get; set; }
        public string JdfmassUm { get; set; }
        public string DefaultUm { get; set; }
        public string PartInfoJob { get; set; }
        public int? NumberOfKinds { get; set; }
        public int? NumOfLytsForFeeders { get; set; }
        public string P2pactualChildrenNameArray { get; set; }
        public string P2pmaxChildrenFeedersArray { get; set; }
        public string P2pactualChildrenFeedersArray { get; set; }
        public int? P2pactualChildFeeders { get; set; }
        public string TopLevelUserId { get; set; }
        public bool? PbinPowerOf2 { get; set; }
        public int? PbuserDefined { get; set; }
        public int? MaxPgPerSection { get; set; }
        public string PreferredWorkStyle { get; set; }
        public decimal? QtyIn1stFinishing { get; set; }
        public bool? ZeroPrintingCostWiz { get; set; }
        public bool? ZeroPrintingCostMfg { get; set; }
        public bool? ZeroPrintingCost { get; set; }
        public string StandardTypeName { get; set; }
        public string PartIntentSummary1 { get; set; }
        public string PartIntentSummary2 { get; set; }
        public string PartIntentSummary3 { get; set; }
        public bool? InvalidImpoInput { get; set; }
        public bool? FalseForRel { get; set; }
        public bool? TrueForRel { get; set; }
        public int? IsOpWithBindFinE { get; set; }
        public int? IsFinDefWithBind { get; set; }
        public int? IsFinParentMfgmpOp { get; set; }
        public int? IsFinParentWizMpOp { get; set; }
        public string BindingSideWiz { get; set; }
        public string BindingSideMfg { get; set; }
        public string BindingSide { get; set; }
        public string JogSide { get; set; }
        public decimal? Milling { get; set; }
        public decimal? HeadTrim { get; set; }
        public decimal? FootTrim { get; set; }
        public decimal? FaceTrim { get; set; }
        public decimal? BackTrim { get; set; }
        public decimal? Spine { get; set; }
        public decimal? PrintedPartThickness { get; set; }
        public decimal? FrontLip { get; set; }
        public decimal? BackLip { get; set; }
        public decimal? HorizontalCreep { get; set; }
        public decimal? VerticalCreep { get; set; }
        public bool? IsCoverWiz { get; set; }
        public bool? IsCoverMfg { get; set; }
        public bool? IsCover { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PlantDescription { get; set; }
        public bool? IsPlantDiffTopPlant { get; set; }
        public bool? ValidIsPlantDiffTopPlant { get; set; }
        public int? FlatWorkPagesX { get; set; }
        public int? FlatWorkPagesY { get; set; }
        public string MarkupLevelsPartOriginal { get; set; }
        public string MarkupLevelsPart { get; set; }
        public string MarkupLevelsEst { get; set; }
        public string MarkupLevels { get; set; }
        public string MarkupLevelsPartNames { get; set; }
        public string MarkupLevelsEstNames { get; set; }
        public string MarkupLevelsMfgElements { get; set; }
        public int? ScenarioDefaultIdSttc { get; set; }
        public int? PressIdSttc { get; set; }
        public int? StockIdmfgSttc { get; set; }
        public int? StockIdOvrd { get; set; }
        public int? PrepressDefaultsIdSttc { get; set; }
        public int? PrepressDefaultsDescOvrd { get; set; }
        public int? PlateIdOvrd { get; set; }
        public int? PrepressCutterIdOvrd { get; set; }
        public int? PostpressCutterIdOvrd { get; set; }
        public int? FolderIdOvrd { get; set; }
        public int? GripperGapAllowanceOvrd { get; set; }
        public int? SideMarginOvrd { get; set; }
        public int? HeadFootMarginOvrd { get; set; }
        public int? JdfpartDescMfgSttc { get; set; }
        public int? BindingStyleMfgSttc { get; set; }
        public int? BindingStyleMfgComboOvrd { get; set; }
        public int? BindingStyleComboOvrd { get; set; }
        public int? FlatPiecesMultMfgSttc { get; set; }
        public int? FlatPiecesMultOvrd { get; set; }
        public int? NumFoldsRightMfgSttc { get; set; }
        public int? NumFoldsParallelMfgSttc { get; set; }
        public int? FinishedWidthMfgSttc { get; set; }
        public int? FinishedWidthOvrd { get; set; }
        public int? FinishedLengthMfgSttc { get; set; }
        public int? FinishedLengthOvrd { get; set; }
        public int? OpenWidthMfgSttc { get; set; }
        public int? OpenWidthOvrd { get; set; }
        public int? OpenLengthMfgSttc { get; set; }
        public int? OpenLengthOvrd { get; set; }
        public int? PagesMfgSttc { get; set; }
        public int? PagesOvrd { get; set; }
        public int? GrainDirectionMfgSttc { get; set; }
        public int? GrainDirectionOvrd { get; set; }
        public int? StockAddlCommentsMfgSttc { get; set; }
        public int? CustSuppliedStockMfgSttc { get; set; }
        public int? WorkingPieceTypeOvrd { get; set; }
        public int? BleedSizeMfgSttc { get; set; }
        public int? BleedSizeOvrd { get; set; }
        public int? WebPressCutOffOvrd { get; set; }
        public int? FinishingDefaultsIdSttc { get; set; }
        public int? FinishingDefaultsDescOvrd { get; set; }
        public int? ColorBarSizeOvrd { get; set; }
        public int? RoundToShtsSttc { get; set; }
        public int? PbinPowerOf2Sttc { get; set; }
        public int? PbuserDefinedSttc { get; set; }
        public int? MaxPgPerSectionSttc { get; set; }
        public int? PreferredWorkStyleSttc { get; set; }
        public int? ZeroPrintingCostMfgSttc { get; set; }
        public int? ZeroPrintingCostOvrd { get; set; }
        public int? BindingSideMfgSttc { get; set; }
        public int? BindingSideOvrd { get; set; }
        public int? JogSideOvrd { get; set; }
        public int? MillingOvrd { get; set; }
        public int? HeadTrimOvrd { get; set; }
        public int? FootTrimOvrd { get; set; }
        public int? FaceTrimOvrd { get; set; }
        public int? BackTrimOvrd { get; set; }
        public int? SpineOvrd { get; set; }
        public int? FrontLipOvrd { get; set; }
        public int? BackLipOvrd { get; set; }
        public int? HorizontalCreepOvrd { get; set; }
        public int? VerticalCreepOvrd { get; set; }
        public int? IsCoverMfgSttc { get; set; }
        public int? IsCoverOvrd { get; set; }
        public int? PlantSttc { get; set; }
        public int? MarkupLevelsPartOriginalSttc { get; set; }
        public int? MarkupLevelsPartOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public decimal? FinishedWidthUntrimmedWiz { get; set; }
        public decimal? FinishedWidthUntrimmedMfg { get; set; }
        public int? FinishedWidthUntrimmedMfgSttc { get; set; }
        public decimal? FinishedWidthUntrimmed { get; set; }
        public int? FinishedWidthUntrimmedOvrd { get; set; }
        public decimal? FinishedLengthUntrimmedWiz { get; set; }
        public decimal? FinishedLengthUntrimmedMfg { get; set; }
        public int? FinishedLengthUntrimmedMfgSttc { get; set; }
        public decimal? FinishedLengthUntrimmed { get; set; }
        public int? FinishedLengthUntrimmedOvrd { get; set; }
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
        public bool? StockReuseMfg { get; set; }
        public int? StockReuseMfgSttc { get; set; }
        public bool? StockReuse { get; set; }
        public int? StockReuseOvrd { get; set; }
        public bool? IncInFinSizeAdjWiz { get; set; }
        public bool? IncInFinSizeAdjMfg { get; set; }
        public int? IncInFinSizeAdjMfgSttc { get; set; }
        public bool? IncInFinSizeAdj { get; set; }

        public virtual EsEstprefs EstPrefs { get; set; }
        public virtual EsEstimationqty EstQty { get; set; }
        public virtual EsPart Part { get; set; }
        public virtual ICollection<EsEstimatematerial> EsEstimatematerial { get; set; }
        public virtual ICollection<EsEstimateoperations> EsEstimateoperations { get; set; }
        public virtual ICollection<EsFinishe> EsFinishe { get; set; }
        public virtual ICollection<EsFoldingelg> EsFoldingelg { get; set; }
        public virtual ICollection<EsFoldingemain> EsFoldingemain { get; set; }
        public virtual ICollection<EsImplg> EsImplg { get; set; }
        public virtual ICollection<EsImpmain> EsImpmain { get; set; }
        public virtual ICollection<EsInkelg> EsInkelg { get; set; }
        public virtual ICollection<EsInkemain> EsInkemain { get; set; }
        public virtual ICollection<EsInlinee> EsInlinee { get; set; }
        public virtual ICollection<EsPlatee> EsPlatee { get; set; }
        public virtual ICollection<EsPostcutelg> EsPostcutelg { get; set; }
        public virtual ICollection<EsPostcutemain> EsPostcutemain { get; set; }
        public virtual ICollection<EsPrecute> EsPrecute { get; set; }
        public virtual ICollection<EsPrepresse> EsPrepresse { get; set; }
        public virtual ICollection<EsPresselg> EsPresselg { get; set; }
        public virtual ICollection<EsPressemain> EsPressemain { get; set; }
        public virtual ICollection<EsStockeform> EsStockeform { get; set; }
        public virtual ICollection<EsStockelg> EsStockelg { get; set; }
        public virtual ICollection<EsStockemain> EsStockemain { get; set; }
    }
}
