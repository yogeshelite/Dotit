using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsPidefaults
    {
        public EsPidefaults()
        {
            EsPart = new HashSet<EsPart>();
            EsPidefaultsink = new HashSet<EsPidefaultsink>();
            EsPidefaultssbf = new HashSet<EsPidefaultssbf>();
        }

        public string RecId { get; set; }
        public string Company { get; set; }
        public string PidefaultsUserId { get; set; }
        public string PidefaultsDesc { get; set; }
        public string EstPrefId { get; set; }
        public string ScenarioDefId { get; set; }
        public string ScenarioDefaultsDesc { get; set; }
        public int? PartType { get; set; }
        public int? BindingStyle { get; set; }
        public bool? SelfBound { get; set; }
        public int? FlatPiecesMult { get; set; }
        public int? Pages { get; set; }
        public string SizeIdfin { get; set; }
        public string SizeUserIdfin { get; set; }
        public decimal? WidthFin { get; set; }
        public decimal? LengthFin { get; set; }
        public decimal? WidthOpen { get; set; }
        public decimal? LengthOpen { get; set; }
        public bool? CustSuppliedStock { get; set; }
        public int? NumFoldsRight { get; set; }
        public int? NumFoldsParallel { get; set; }
        public string AttchPath { get; set; }
        public string AttchFileName { get; set; }
        public string GrainDirection { get; set; }
        public decimal? DefBleedSize1 { get; set; }
        public int? Registration { get; set; }
        public string RegistrationName { get; set; }
        public string StockId { get; set; }
        public string StockDesc { get; set; }
        public bool? FoldedBrochure { get; set; }
        public bool? Glue { get; set; }
        public string FoldGlueId { get; set; }
        public bool? Inactive { get; set; }
        public string UirecIdentifier { get; set; }
        public string BindingSide { get; set; }
        public string FoldTagId { get; set; }
        public string FoldTagUserId { get; set; }
        public string FoldTagPicPath { get; set; }
        public string FoldTagPic { get; set; }
        public bool? IsCover { get; set; }
        public int? PagesX { get; set; }
        public int? PagesY { get; set; }
        public bool? ZeroPrintingCost { get; set; }
        public bool? IsBindingCollectAndSideNone { get; set; }
        public string MarkupLevels { get; set; }
        public int? WidthFinOvrd { get; set; }
        public int? LengthFinOvrd { get; set; }
        public int? WidthOpenOvrd { get; set; }
        public int? LengthOpenOvrd { get; set; }
        public int? FoldTagUserIdOvrd { get; set; }
        public int? PagesXOvrd { get; set; }
        public int? PagesYOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string CaseBindingPartType { get; set; }
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
        public decimal? FinalPartDups { get; set; }

        public virtual EsEstprefs EstPref { get; set; }
        public virtual EsScenariodefaults ScenarioDef { get; set; }
        public virtual EsStocksizes SizeIdfinNavigation { get; set; }
        public virtual EsStock Stock { get; set; }
        public virtual ICollection<EsPart> EsPart { get; set; }
        public virtual ICollection<EsPidefaultsink> EsPidefaultsink { get; set; }
        public virtual ICollection<EsPidefaultssbf> EsPidefaultssbf { get; set; }
    }
}
