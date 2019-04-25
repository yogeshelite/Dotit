using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPostcutemain
    {
        public EsPostcutemain()
        {
            EsPostcutelg = new HashSet<EsPostcutelg>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string EstimationId { get; set; }
        public string StdType { get; set; }
        public string Plant { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? RunHr { get; set; }
        public decimal? TotalHr { get; set; }
        public decimal? ShtsToCutNet { get; set; }
        public int? SetupShts { get; set; }
        public decimal? ShtsToCut { get; set; }
        public decimal? TotalShts { get; set; }
        public string StdTypeName { get; set; }
        public string VgtoDisplayUnderName { get; set; }
        public string VgorderInStdType { get; set; }
        public string VgorderInPlan { get; set; }
        public string OrderWithinIdentical { get; set; }
        public string ViewingType { get; set; }
        public string UnpaddedSyncNumber { get; set; }
        public string SyncNumber { get; set; }
        public string ThisErecordOrderInVg { get; set; }
        public string OrderInPlan { get; set; }
        public decimal? ValueIfLastMain { get; set; }
        public decimal? QtyOutMain { get; set; }
        public decimal? QtyInMain { get; set; }
        public decimal? SpoilShts { get; set; }
        public int? SetupStockShts { get; set; }
        public decimal? SpoilStockShts { get; set; }
        public decimal? ProdWasteStockShts { get; set; }
        public decimal? QtyInMainStockShts { get; set; }
        public decimal? QtyOutMainStockShts { get; set; }
        public int? ErrorsInThisErecord { get; set; }
        public bool? IsSbforPostCut { get; set; }
        public bool? IsLastSbforPostCut { get; set; }
        public decimal? QoutMainStockSbfpcut { get; set; }
        public bool? Is1stSbforPostCut { get; set; }
        public decimal? QinMainStockSbfpcut { get; set; }
        public int? NumOfCuts { get; set; }
        public decimal? TotalLifts { get; set; }
        public string TopLevelUserId { get; set; }
        public int? VgorderInStdTypeOvrd { get; set; }
        public int? ThisErecordOrderInVgOvrd { get; set; }
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

        public virtual EsMpoptions Option { get; set; }
        public virtual ICollection<EsPostcutelg> EsPostcutelg { get; set; }
    }
}
