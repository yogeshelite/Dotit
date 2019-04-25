using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPart
    {
        public EsPart()
        {
            EsMpoptions = new HashSet<EsMpoptions>();
            EsPartfinishing = new HashSet<EsPartfinishing>();
            EsPartink = new HashSet<EsPartink>();
            EsPartprepress = new HashSet<EsPartprepress>();
            EsPartqty = new HashSet<EsPartqty>();
            EsPartsbf = new HashSet<EsPartsbf>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string PartUserId { get; set; }
        public string PartDesc { get; set; }
        public string PartDescUi { get; set; }
        public string Plant { get; set; }
        public string PlantDescription { get; set; }
        public int? PartType { get; set; }
        public int? IsPrintingPart { get; set; }
        public bool? MultipleParents { get; set; }
        public string EstimateUserId { get; set; }
        public bool? Mfgcreated { get; set; }
        public int? MfgcreatedInt { get; set; }
        public int? BindingStyle { get; set; }
        public string BindingStyleUi { get; set; }
        public bool? SelfBound { get; set; }
        public int? FlatPiecesMult { get; set; }
        public int? Pages { get; set; }
        public int? PagesInPrinitngPart { get; set; }
        public decimal? PrintedPartThickness { get; set; }
        public string SizeIdfin { get; set; }
        public string SizeUserIdfin { get; set; }
        public decimal? TmpWidthOpen { get; set; }
        public decimal? TmpLengthOpen { get; set; }
        public decimal? WidthFin { get; set; }
        public decimal? LengthFin { get; set; }
        public decimal? WidthOpen { get; set; }
        public decimal? LengthOpen { get; set; }
        public string AttchPath { get; set; }
        public string AttchFileName { get; set; }
        public bool? AttchOpenButton { get; set; }
        public int? NumFoldsRight { get; set; }
        public int? NumFoldsParallel { get; set; }
        public string JdfpartDesc { get; set; }
        public string EstimateId { get; set; }
        public string EstPrefsId { get; set; }
        public string PidefId { get; set; }
        public string PidefUserId { get; set; }
        public string StockId { get; set; }
        public string StockUserId { get; set; }
        public string StockDescription { get; set; }
        public string StockAddlComments { get; set; }
        public bool? CustSuppliedStock { get; set; }
        public string GrainDirection { get; set; }
        public string MultiPressRun { get; set; }
        public int? PartReg { get; set; }
        public string PartOrSubPart { get; set; }
        public string DisplayOrderId { get; set; }
        public int? NumOfBookmarks { get; set; }
        public string JobAsmComment { get; set; }
        public bool? SavedPrintingWizard { get; set; }
        public bool? ForPrintingWizard { get; set; }
        public bool? InitializationDone { get; set; }
        public bool? ResultsAccepted { get; set; }
        public bool? QtyRequired { get; set; }
        public bool? FoldedBrochure { get; set; }
        public bool? Glue { get; set; }
        public string FoldGlueId { get; set; }
        public decimal? RoundToWeight { get; set; }
        public string ParentId { get; set; }
        public bool? PartIsTopPart { get; set; }
        public string InkId { get; set; }
        public string InkUserId { get; set; }
        public string InkSide { get; set; }
        public string InkFront { get; set; }
        public string InkBack { get; set; }
        public bool? IsInkOnTwoSides { get; set; }
        public string Sbfid { get; set; }
        public string SbfuserId { get; set; }
        public string Sbfside { get; set; }
        public decimal? BleedSize { get; set; }
        public bool? IsBleed { get; set; }
        public string PrintMethod { get; set; }
        public string TmpPrintMethod { get; set; }
        public bool? Cover { get; set; }
        public bool? CaseBind { get; set; }
        public int? QuoteNum { get; set; }
        public string OptionPositionDescTemp { get; set; }
        public string ScenarioDefId { get; set; }
        public string ScenarioDefUserId { get; set; }
        public int? VarPrintingNumOfTextBox { get; set; }
        public int? VarPrintingNumOfPics { get; set; }
        public string PartOrderInEstimateForJob { get; set; }
        public string ImpostionTemplateProducer { get; set; }
        public bool? KeepManuallyCreatedRecords { get; set; }
        public int? OrderWithinParent { get; set; }
        public string ParentOrder { get; set; }
        public string OrderInEstimate { get; set; }
        public string ParentMatch { get; set; }
        public string PartMatch { get; set; }
        public int? NumWizOptionsSelected { get; set; }
        public int? QuoteLine { get; set; }
        public string OrderPart { get; set; }
        public int? ErrorsInPartWiz { get; set; }
        public int? ErrorsInPartMfg { get; set; }
        public bool? TrueTemp { get; set; }
        public string ParentPartName { get; set; }
        public bool? IsImmediateSon { get; set; }
        public int? UinumOfColorPrePart { get; set; }
        public decimal? UipressShtWidthPrePart { get; set; }
        public decimal? UipressShtLengthPrePart { get; set; }
        public int? UinumOfLayoutsPrePart { get; set; }
        public int? UilgqtyPrepsPart { get; set; }
        public int? UinumOfPlatesPrePart { get; set; }
        public bool? PrepPartError { get; set; }
        public bool? NextButtonBinding { get; set; }
        public bool? BackButtonBinding { get; set; }
        public bool? CreateMfgPlans { get; set; }
        public string SelectScenarioBy { get; set; }
        public bool? FoldTagBtnBinding { get; set; }
        public bool? CalculatePricingAction { get; set; }
        public string AsmBlnameForPrepressAsm { get; set; }
        public string PartFormName { get; set; }
        public string TopLevelUserId { get; set; }
        public bool? ZeroPrintingCost { get; set; }
        public int? AllowMfgerror { get; set; }
        public bool? IsSharedPart { get; set; }
        public string BindingSide { get; set; }
        public string FoldTagId { get; set; }
        public string FoldTagUserId { get; set; }
        public string FoldTagPicPath { get; set; }
        public string FoldTagPic { get; set; }
        public bool? IsCover { get; set; }
        public string PlantsInUse { get; set; }
        public string MarkupLevels { get; set; }
        public int? PartDescOvrd { get; set; }
        public int? PlantOvrd { get; set; }
        public int? BindingStyleOvrd { get; set; }
        public int? SelfBoundOvrd { get; set; }
        public int? FlatPiecesMultOvrd { get; set; }
        public int? PagesSttc { get; set; }
        public int? SizeIdfinOvrd { get; set; }
        public int? WidthFinSttc { get; set; }
        public int? LengthFinSttc { get; set; }
        public int? WidthOpenSttc { get; set; }
        public int? LengthOpenSttc { get; set; }
        public int? AttchPathOvrd { get; set; }
        public int? AttchFileNameOvrd { get; set; }
        public int? NumFoldsRightOvrd { get; set; }
        public int? NumFoldsParallelOvrd { get; set; }
        public int? EstPrefsIdSttc { get; set; }
        public int? PidefIdSttc { get; set; }
        public int? StockIdSttc { get; set; }
        public int? CustSuppliedStockOvrd { get; set; }
        public int? GrainDirectionSttc { get; set; }
        public int? PartRegSttc { get; set; }
        public int? FoldedBrochureSttc { get; set; }
        public int? GlueSttc { get; set; }
        public int? FoldGlueIdSttc { get; set; }
        public int? BleedSizeSttc { get; set; }
        public int? ScenarioDefIdSttc { get; set; }
        public int? SelectScenarioByOvrd { get; set; }
        public int? ZeroPrintingCostSttc { get; set; }
        public int? BindingSideSttc { get; set; }
        public int? FoldTagIdSttc { get; set; }
        public int? IsCoverSttc { get; set; }
        public int? MarkupLevelsSttc { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string CommentPartStock { get; set; }
        public string CommentPartInk { get; set; }
        public string CommentPartSbf { get; set; }
        public string CommentPartFinishing { get; set; }
        public string CommentPartPrepress { get; set; }
        public string CommentPartGeneral { get; set; }
        public string FinishingDefaultsId { get; set; }
        public string FinishingDefaultsUserId { get; set; }
        public string FinishingDefaultsDesc { get; set; }
        public string PrepressDefaultsId { get; set; }
        public string PrepressDefaultsUserId { get; set; }
        public string PrepressDefaultsDesc { get; set; }
        public string FinishingId { get; set; }
        public string PrepressId { get; set; }
        public string UserDefineComment1 { get; set; }
        public string UserDefineComment2 { get; set; }
        public string UserDefineComment3 { get; set; }
        public string UserDefineComment4 { get; set; }
        public string UserDefineComment5 { get; set; }
        public string UserDefineComment6 { get; set; }
        public string UserDefineComment7 { get; set; }
        public string UserDefineComment8 { get; set; }
        public string UserDefineComment9 { get; set; }
        public string UserDefineComment10 { get; set; }
        public int? FinishingDefaultsIdSttc { get; set; }
        public int? PrepressDefaultsIdSttc { get; set; }
        public bool? CuttingOnlyPart { get; set; }
        public int? CuttingOnlyPartOvrd { get; set; }
        public string StockSrcCutPartId { get; set; }
        public decimal? WidthFinUntrimmed { get; set; }
        public int? WidthFinUntrimmedOvrd { get; set; }
        public decimal? LengthFinUntrimmed { get; set; }
        public int? LengthFinUntrimmedOvrd { get; set; }
        public string CaseBindingPartType { get; set; }
        public int? CaseBindingPartTypeSttc { get; set; }
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
        public string UserChar1Ink { get; set; }
        public string UserChar2Ink { get; set; }
        public decimal? UserDecimal1Ink { get; set; }
        public decimal? UserDecimal2Ink { get; set; }
        public DateTime? UserDate1Ink { get; set; }
        public DateTime? UserDate2Ink { get; set; }
        public string UserChar1Sbf { get; set; }
        public string UserChar2Sbf { get; set; }
        public decimal? UserDecimal1Sbf { get; set; }
        public decimal? UserDecimal2Sbf { get; set; }
        public DateTime? UserDate1Sbf { get; set; }
        public DateTime? UserDate2Sbf { get; set; }
        public decimal? BookBlockCaliper { get; set; }
        public bool? StockReuse { get; set; }
        public int? StockReuseOvrd { get; set; }
        public decimal? FinalPartDups { get; set; }
        public int? FinalPartDupsOvrd { get; set; }
        public decimal? SoftCoverFlapFront { get; set; }
        public int? SoftCoverFlapFrontOvrd { get; set; }
        public decimal? SoftCoverFlapBack { get; set; }
        public int? SoftCoverFlapBackOvrd { get; set; }

        public virtual EsEstprefs EstPrefs { get; set; }
        public virtual EsFinishingdefaults FinishingDefaults { get; set; }
        public virtual EsPidefaults Pidef { get; set; }
        public virtual EsPrepressdefaults PrepressDefaults { get; set; }
        public virtual EsScenariodefaults ScenarioDef { get; set; }
        public virtual EsStocksizes SizeIdfinNavigation { get; set; }
        public virtual EsStock Stock { get; set; }
        public virtual ICollection<EsMpoptions> EsMpoptions { get; set; }
        public virtual ICollection<EsPartfinishing> EsPartfinishing { get; set; }
        public virtual ICollection<EsPartink> EsPartink { get; set; }
        public virtual ICollection<EsPartprepress> EsPartprepress { get; set; }
        public virtual ICollection<EsPartqty> EsPartqty { get; set; }
        public virtual ICollection<EsPartsbf> EsPartsbf { get; set; }
    }
}
