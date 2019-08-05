using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsStockproctype
    {
        public EsStockproctype()
        {
            EsStockeform = new HashSet<EsStockeform>();
            EsStockemain = new HashSet<EsStockemain>();
            EsStockitemsize = new HashSet<EsStockitemsize>();
        }

        public string RecId { get; set; }
        public string ProcessTypeId { get; set; }
        public string StockId { get; set; }
        public string Company { get; set; }
        public bool? Inactive { get; set; }
        public bool? ParentRecordInactive { get; set; }
        public string StockUomclassId { get; set; }
        public int CostPer { get; set; }
        public string CalcBy { get; set; }
        public string CalcByUom { get; set; }
        public string MaterialMarkupLevels { get; set; }
        public string MaterialMarkupPercents { get; set; }
        public decimal? DivisionFactor { get; set; }
        public string ProcessTypeUserId { get; set; }
        public string GroupId { get; set; }
        public int? RecordExists { get; set; }
        public string ShtSqUi { get; set; }
        public string CostBaseUi { get; set; }
        public string UirecIdentifier { get; set; }
        public string TopLevelUserId { get; set; }
        public string CostUom { get; set; }
        public string LevelUnits { get; set; }
        public string LevelUnitsQtyPer { get; set; }
        public string LevelCost { get; set; }
        public int? CostUomOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string StockUserId { get; set; }
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

        public virtual EsProcesstype ProcessType { get; set; }
        public virtual EsStock Stock { get; set; }
        public virtual ICollection<EsStockeform> EsStockeform { get; set; }
        public virtual ICollection<EsStockemain> EsStockemain { get; set; }
        public virtual ICollection<EsStockitemsize> EsStockitemsize { get; set; }
    }
}
