using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsInkmileage
    {
        public EsInkmileage()
        {
            EsInkemain = new HashSet<EsInkemain>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string InkMileageUserId { get; set; }
        public string InkId { get; set; }
        public string InkDtlId { get; set; }
        public string ProcessTypeId { get; set; }
        public string StockCategoryId { get; set; }
        public string StockCategoryUserId { get; set; }
        public int? Mileage { get; set; }
        public bool? Inactive { get; set; }
        public string GroupId { get; set; }
        public string StockCategoryDesc { get; set; }
        public bool? ParentRecordInactive { get; set; }
        public bool? GrandParentRecordInactive { get; set; }
        public string UirecIdentifier { get; set; }
        public string TopLevelUserId { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string InkUserId { get; set; }
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

        public virtual EsInkdtl InkDtl { get; set; }
        public virtual EsStockcategory StockCategory { get; set; }
        public virtual ICollection<EsInkemain> EsInkemain { get; set; }
    }
}
