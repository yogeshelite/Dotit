using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsStockitemsize
    {
        public EsStockitemsize()
        {
            EsStockeform = new HashSet<EsStockeform>();
            EsStockemain = new HashSet<EsStockemain>();
        }

        public string RecId { get; set; }
        public bool? TmpTrue { get; set; }
        public string Company { get; set; }
        public string StockItemSizeUserId { get; set; }
        public string StockItemSizeDesc { get; set; }
        public string StockId { get; set; }
        public string ProcessTypeId { get; set; }
        public string ProcessTypeUserId { get; set; }
        public bool? IsWeb { get; set; }
        public string StockProcTypeId { get; set; }
        public bool? Inactive { get; set; }
        public bool? ParentRecordInactive { get; set; }
        public bool? GrandParentRecordInactive { get; set; }
        public string MatPartNum { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string GrainDirection { get; set; }
        public string GrainDirectionUiDisplay { get; set; }
        public bool? SetSizeCost { get; set; }
        public string LevelUnits { get; set; }
        public string LevelUnitsQtyPer { get; set; }
        public string LevelCost { get; set; }
        public string StckDtlItemPartDesc { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorDesc { get; set; }
        public string CostPer38x25x1000 { get; set; }
        public string BasicSizeCost { get; set; }
        public string GroupId { get; set; }
        public int? RecordExists { get; set; }
        public decimal? RollWeight { get; set; }
        public string UirecIdentifier { get; set; }
        public string StockUomclassId { get; set; }
        public int? Uomselected { get; set; }
        public int? CostSourceSelected { get; set; }
        public string CostSourceOptions { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string EstUom { get; set; }
        public string IumTobeDeleted { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcostIfPart { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public string CostSourceTexts { get; set; }
        public string UomoptionsCombo { get; set; }
        public string CostSourceTextsCombo { get; set; }
        public string ConvFromOneCostUomTxt { get; set; }
        public string ConToInvEquivalentTxt { get; set; }
        public string TopLevelUserId { get; set; }
        public string MatAnalysisCode { get; set; }
        public bool? MatIsMissingAnalysCode { get; set; }
        public decimal? InvToCostFactor { get; set; }
        public int? InvToCostDirection { get; set; }
        public bool? IsWebAndOtf { get; set; }
        public string CostUom { get; set; }
        public bool? IsCostUomdiffFromPart { get; set; }
        public bool? IsIumsheets { get; set; }
        public decimal? Mweight { get; set; }
        public bool? IsStandTmpFactorDiffFromPart { get; set; }
        public int? LevelUnitsOvrd { get; set; }
        public int? LevelCostOvrd { get; set; }
        public int? StckDtlItemPartDescOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? EstUomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? InvToCostFactorOvrd { get; set; }
        public int? InvToCostDirectionOvrd { get; set; }
        public int? MweightOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string StockUserId { get; set; }
        public string ResultsLengthUom { get; set; }
        public int? ResultsLengthUomOvrd { get; set; }
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
        public decimal? MinQty { get; set; }
        public decimal? RoundQtyTo { get; set; }

        public virtual EsStockproctype StockProcType { get; set; }
        public virtual ICollection<EsStockeform> EsStockeform { get; set; }
        public virtual ICollection<EsStockemain> EsStockemain { get; set; }
    }
}
