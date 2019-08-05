using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsPartqty
    {
        public string Company { get; set; }
        public string RecId { get; set; }
        public string PartId { get; set; }
        public string EstQtyId { get; set; }
        public string EstimateId { get; set; }
        public string PartUserId { get; set; }
        public string ParentId { get; set; }
        public string ParentUserId { get; set; }
        public decimal? ParentQty { get; set; }
        public decimal? QtyPer { get; set; }
        public int? OverRunQty { get; set; }
        public decimal? Qty { get; set; }
        public decimal? RatioPartToParent { get; set; }
        public int? QtyPos { get; set; }
        public int? QtyPosIndex { get; set; }
        public string TopLevelUserId { get; set; }
        public bool? IsStepParentQty { get; set; }
        public int? SumByQtyPos { get; set; }
        public int? ParentIdOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public int? QtyPerOvrd { get; set; }
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

        public virtual EsEstimationqty EstQty { get; set; }
        public virtual EsPart Part { get; set; }
    }
}
