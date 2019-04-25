using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsInk
    {
        public EsInk()
        {
            EsInkdtl = new HashSet<EsInkdtl>();
            EsInkemain = new HashSet<EsInkemain>();
            EsPartink = new HashSet<EsPartink>();
            EsPidefaultsink = new HashSet<EsPidefaultsink>();
            EsPress = new HashSet<EsPress>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string InkUserId { get; set; }
        public string StdType { get; set; }
        public string StdTypeUserId { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public string InkDesc { get; set; }
        public string CustomerDesc { get; set; }
        public bool? Inactive { get; set; }
        public bool? IsCoating { get; set; }
        public string GroupId { get; set; }
        public string GroupUserId { get; set; }
        public string EstimationDisplayGroup { get; set; }
        public bool? GroupToViewingGroup { get; set; }
        public string GroupOrderInStdType { get; set; }
        public string StdTypeOrderInMfgPlan { get; set; }
        public string OrderInGroup { get; set; }
        public int? NumOfInks { get; set; }
        public string InkType { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? ShowInRfq { get; set; }
        public bool? JdfisCayan { get; set; }
        public bool? JdfisMagenta { get; set; }
        public bool? JdfisYellow { get; set; }
        public bool? JdfisBlack { get; set; }
        public bool? JdfisOther { get; set; }
        public string MarkupLevels { get; set; }
        public int? CustomerDescOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
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

        public virtual EsGroups Group { get; set; }
        public virtual EsStdtype StdTypeNavigation { get; set; }
        public virtual ICollection<EsInkdtl> EsInkdtl { get; set; }
        public virtual ICollection<EsInkemain> EsInkemain { get; set; }
        public virtual ICollection<EsPartink> EsPartink { get; set; }
        public virtual ICollection<EsPidefaultsink> EsPidefaultsink { get; set; }
        public virtual ICollection<EsPress> EsPress { get; set; }
    }
}
