using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsInkdtl
    {
        public EsInkdtl()
        {
            EsInkemain = new HashSet<EsInkemain>();
            EsInkmileage = new HashSet<EsInkmileage>();
        }

        public string RecId { get; set; }
        public string InkDtlUserId { get; set; }
        public string InkId { get; set; }
        public bool? TmpTrue { get; set; }
        public string Company { get; set; }
        public string InkDesc { get; set; }
        public bool? Inactive { get; set; }
        public bool? ParentRecordInactive { get; set; }
        public string ProcessTypeId { get; set; }
        public string ProcessTypeUserId { get; set; }
        public string MatPartNum { get; set; }
        public string MatPartDesc { get; set; }
        public int? NumOfInks { get; set; }
        public int? BlackWashup { get; set; }
        public int? SpotWashup { get; set; }
        public int? ProcessWashup { get; set; }
        public int? VarnishWashup { get; set; }
        public decimal? MinUnits { get; set; }
        public string DeptId { get; set; }
        public int? Uomselected { get; set; }
        public int? CostSourceSelected { get; set; }
        public string CostSourceOptions { get; set; }
        public bool? IsMatInPartsTbl { get; set; }
        public string EstUom { get; set; }
        public string Ium { get; set; }
        public bool? IsZeroEstOrinvUomfactorToBase { get; set; }
        public decimal? ConversionFactor { get; set; }
        public decimal? SelectedUomcost { get; set; }
        public string CostSourceTexts { get; set; }
        public string UomoptionsCombo { get; set; }
        public string CostSourceTextsCombo { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public decimal? CostPerUnit { get; set; }
        public string InkMixingDesc { get; set; }
        public string OperationId { get; set; }
        public string OperationDesc { get; set; }
        public decimal? SetupHr { get; set; }
        public decimal? MixHrPerUnit { get; set; }
        public string LaborMarkupLevels { get; set; }
        public string LaborMarkupPercents { get; set; }
        public string MaterialMarkupLevels { get; set; }
        public string MaterialMarkupPercents { get; set; }
        public int? VendorNum { get; set; }
        public string VendorId { get; set; }
        public string VendorDesc { get; set; }
        public string SystemIdvendorData { get; set; }
        public bool? CreatePoreq { get; set; }
        public bool? LaborIncluded { get; set; }
        public string GroupId { get; set; }
        public string UirecIdentifier { get; set; }
        public bool? IsSchedResExist { get; set; }
        public bool? AllowInCurPlant { get; set; }
        public string TopLevelUserId { get; set; }
        public string MatAnalysisCode { get; set; }
        public bool? MatIsMissingAnalysCode { get; set; }
        public string OpAnalysisCode { get; set; }
        public bool? OpIsMissingAnalysCode { get; set; }
        public string OpAnalysisCodeDesc { get; set; }
        public int? MatPartDescOvrd { get; set; }
        public int? EstUomOvrd { get; set; }
        public int? SelectedUomcostOvrd { get; set; }
        public int? VendorNumOvrd { get; set; }
        public int? MatAnalysisCodeOvrd { get; set; }
        public int? OpAnalysisCodeOvrd { get; set; }
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

        public virtual EsInk Ink { get; set; }
        public virtual EsProcesstype ProcessType { get; set; }
        public virtual ICollection<EsInkemain> EsInkemain { get; set; }
        public virtual ICollection<EsInkmileage> EsInkmileage { get; set; }
    }
}
