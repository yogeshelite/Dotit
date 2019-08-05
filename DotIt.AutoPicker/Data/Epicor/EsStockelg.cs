using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsStockelg
    {
        public EsStockelg()
        {
            EsStockeform = new HashSet<EsStockeform>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string Plant { get; set; }
        public string StockEmainId { get; set; }
        public string StockId { get; set; }
        public string StockUserId { get; set; }
        public string StockDesc { get; set; }
        public string CustomerDesc { get; set; }
        public string EstimateId { get; set; }
        public string PartId { get; set; }
        public string ImpLgid { get; set; }
        public string LgnumUi { get; set; }
        public int? Lgnum { get; set; }
        public decimal? PctOfPart { get; set; }
        public string ImpSummary { get; set; }
        public string LytSummary { get; set; }
        public int? NumOfLayouts { get; set; }
        public decimal? NetStockShtsLg { get; set; }
        public decimal? NetStockShtsLyt { get; set; }
        public int? PreCutSetupLyt { get; set; }
        public int? PreCutSetupLg { get; set; }
        public decimal? PreCutSpoilLyt { get; set; }
        public decimal? PreCutSetupSpoilLg { get; set; }
        public int? PressSetup1stLyt { get; set; }
        public int? PressSetupFollLyt { get; set; }
        public int? PressSetupLg { get; set; }
        public decimal? PressSpoilLyt { get; set; }
        public decimal? PressSpoilLg { get; set; }
        public int? PostCutSbfsetup1stLyt { get; set; }
        public int? PostCutSbfsetupFoll { get; set; }
        public int? PostCutSbfsetupLg { get; set; }
        public decimal? PostCutSbfspoilLyt { get; set; }
        public decimal? PostCutSbfspoilLg { get; set; }
        public int? FoldSetup1st { get; set; }
        public int? FoldSetupFollLyt { get; set; }
        public int? FoldSetupLg { get; set; }
        public decimal? FoldSpoilLyt { get; set; }
        public decimal? FoldSpoilLg { get; set; }
        public int? FinishingSetup1stLyt { get; set; }
        public int? FinishingSetupFollLyt { get; set; }
        public int? FinishingSetupLg { get; set; }
        public decimal? FinishingSpoilLyt { get; set; }
        public decimal? FinishingSpoilLg { get; set; }
        public int? MrAll1stLyt { get; set; }
        public int? MrAllFollLyt { get; set; }
        public int? SetupAllLg { get; set; }
        public decimal? SpoilAllLyt { get; set; }
        public decimal? SpoilAllLg { get; set; }
        public int? AddSht1stLg1stLyt { get; set; }
        public decimal? Total1stLyt { get; set; }
        public decimal? TotalFollLyt { get; set; }
        public decimal? TotalLg { get; set; }
        public string StockLgsummary { get; set; }
        public decimal? Total1stLytSq { get; set; }
        public decimal? TotalFollLytSq { get; set; }
        public decimal? TotalLgsq { get; set; }
        public decimal? Total1stLytSqShts { get; set; }
        public decimal? TotalFollLytSqShts { get; set; }
        public decimal? TotalLgsqShts { get; set; }
        public decimal? TotalWeight1stLyt { get; set; }
        public decimal? TotalWeightFollLyt { get; set; }
        public decimal? TotalWeightLg { get; set; }
        public decimal? WastedQtyLg { get; set; }
        public bool? IsFormMultiSize { get; set; }
        public bool? IsTop { get; set; }
        public bool? IsLg { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public string MatMfgComment { get; set; }
        public string MatPurchComment { get; set; }
        public string MatPurchComment1stLy { get; set; }
        public string MatPurchCommentFollLy { get; set; }
        public bool? PurchaseDirect { get; set; }
        public string CostUom { get; set; }
        public decimal? CostPer { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string Uom { get; set; }
        public string Ium { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public decimal? Iumcost { get; set; }
        public bool? IsWeb { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public decimal? StdMarkup { get; set; }
        public string MatBlname1st { get; set; }
        public string MatBlnameFoll { get; set; }
        public string MatBlnameLg { get; set; }
        public decimal? LytMultyFormWidth { get; set; }
        public decimal? StockW { get; set; }
        public decimal? StockL { get; set; }
        public decimal? LgnetShtOrSqOrWgt { get; set; }
        public decimal? LytNetShtOrSqOrWgt { get; set; }
        public decimal? LgtotShtOrSqOrWgt { get; set; }
        public decimal? FirstTotShtOrSqOrWgt { get; set; }
        public decimal? FollTotShtOrSqOrWgt { get; set; }
        public int? NumOfWebs { get; set; }
        public bool? IncludeScenario { get; set; }
        public string GrainDirectionUitmp { get; set; }
        public string BasisWeightUi { get; set; }
        public string ProcessTypeUserId { get; set; }
        public string StockAddlComments { get; set; }
        public string TopLevelUserId { get; set; }
        public decimal? Caliper { get; set; }
        public string MatAnalysisCode { get; set; }
        public string CostingUom { get; set; }
        public decimal? CostingFactor { get; set; }
        public int? CostingDirection { get; set; }
        public decimal? CostingUnitVal { get; set; }
        public bool? MakeDirect { get; set; }
        public int? StockDescOvrd { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
        public int? MatPartNumOvrd { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? MatMfgCommentOvrd { get; set; }
        public int? MatPurchCommentOvrd { get; set; }
        public int? MatPurchComment1stLyOvrd { get; set; }
        public int? MatPurchCommentFollLyOvrd { get; set; }
        public int? PurchaseDirectOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? CaliperOvrd { get; set; }
        public int? CostingUomOvrd { get; set; }
        public int? CostingFactorOvrd { get; set; }
        public int? MakeDirectOvrd { get; set; }
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

        public virtual EsImplg ImpLg { get; set; }
        public virtual EsMpoptions Option { get; set; }
        public virtual EsStockemain StockEmain { get; set; }
        public virtual ICollection<EsStockeform> EsStockeform { get; set; }
    }
}
