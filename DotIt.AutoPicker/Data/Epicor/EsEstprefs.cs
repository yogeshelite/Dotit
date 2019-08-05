using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EsEstprefs
    {
        public EsEstprefs()
        {
            EsEstimation = new HashSet<EsEstimation>();
            EsMpoptions = new HashSet<EsMpoptions>();
            EsPart = new HashSet<EsPart>();
            EsPidefaults = new HashSet<EsPidefaults>();
        }

        public string RecId { get; set; }
        public int? NumForRel { get; set; }
        public string Company { get; set; }
        public bool? TmpTrue { get; set; }
        public string RegLevelName1 { get; set; }
        public string RegLevelName2 { get; set; }
        public string RegLevelName3 { get; set; }
        public string RegLevelName4 { get; set; }
        public string RegLevelNameAllArrey { get; set; }
        public string PidefaultsId { get; set; }
        public string PidefaultsDesc { get; set; }
        public string FinishingDefaultsId { get; set; }
        public string FinishingDefaultsDesc { get; set; }
        public string PrepressPartDefaultsId { get; set; }
        public string PrepressPartDefaultsDesc { get; set; }
        public string MarkupLevel1Name { get; set; }
        public string MarkupLevel2Name { get; set; }
        public string MarkupLevel3Name { get; set; }
        public string DefMarkupLevel { get; set; }
        public string MarkupLevelConcat { get; set; }
        public int? MaxPartNumPages { get; set; }
        public decimal? MaxPartLength { get; set; }
        public decimal? MaxPartWidth { get; set; }
        public decimal? MaxPartBleedSize { get; set; }
        public decimal? BindingLipPartBleedSize { get; set; }
        public string PricingSchemaHeadId { get; set; }
        public string PricingSchemaHeadDesc { get; set; }
        public int? EstNumberingStart { get; set; }
        public string ImpostionTemplateProducer { get; set; }
        public string PrepsPath { get; set; }
        public bool? UseInterpolation { get; set; }
        public decimal? UtilizationWarnningLimit { get; set; }
        public decimal? UtilizationErrorLimit { get; set; }
        public decimal? UtilizationWarnningLimitUi { get; set; }
        public decimal? UtilizationErrorLimitUi { get; set; }
        public bool? CreateJdf { get; set; }
        public string Jdfpath { get; set; }
        public string LengthUomclassId { get; set; }
        public string JdflengthUm { get; set; }
        public string AreaUomclassId { get; set; }
        public string JdfareaUm { get; set; }
        public string VolumeUomclassId { get; set; }
        public string JdfvolumeUm { get; set; }
        public string WeightUomclassId { get; set; }
        public string JdfmassUm { get; set; }
        public string StockUomclassId { get; set; }
        public string SheetsUm { get; set; }
        public string StockWeightUom { get; set; }
        public string StockSquareUnitUom { get; set; }
        public string DefaultUm { get; set; }
        public string UseRgroupCosting { get; set; }
        public bool? SaveWizardData { get; set; }
        public bool? Inactive { get; set; }
        public string UirecIdentifier { get; set; }
        public int? DelUniqueValue { get; set; }
        public int? EstimationUserIdnumOfChars { get; set; }
        public int? ExportLevel { get; set; }
        public string BindingStyle1 { get; set; }
        public string BindingStyle2 { get; set; }
        public string BindingStyle3 { get; set; }
        public bool? IsMatAnalysCodeMandatory { get; set; }
        public bool? IsOpAnalysCodeMandatory { get; set; }
        public string EstPrefsUserId { get; set; }
        public string SelectScenarioByDefault { get; set; }
        public string ResultsDefaultColumn1 { get; set; }
        public string ResultsDefaultColumn2 { get; set; }
        public bool? IsResultsColumnsTheSame { get; set; }
        public int? StockUomclassIdOvrd { get; set; }
        public int? SheetsUmOvrd { get; set; }
        public int? StockWeightUomOvrd { get; set; }
        public int? StockSquareUnitUomOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public bool? ReadyToCalcDefault { get; set; }
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
        public string ProdIntentId { get; set; }

        public virtual EsFinishingdefaults FinishingDefaults { get; set; }
        public virtual EsPrepressdefaults PrepressPartDefaults { get; set; }
        public virtual EsPricingschemahead PricingSchemaHead { get; set; }
        public virtual ICollection<EsEstimation> EsEstimation { get; set; }
        public virtual ICollection<EsMpoptions> EsMpoptions { get; set; }
        public virtual ICollection<EsPart> EsPart { get; set; }
        public virtual ICollection<EsPidefaults> EsPidefaults { get; set; }
    }
}
