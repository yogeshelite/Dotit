using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EsEstimateoperations
    {
        public EsEstimateoperations()
        {
            EsEstimateopdtl = new HashSet<EsEstimateopdtl>();
        }

        public string Company { get; set; }
        public string RecId { get; set; }
        public string OptionId { get; set; }
        public string EstQtyId { get; set; }
        public int? Lgnumber { get; set; }
        public int? LytNumber { get; set; }
        public string AssemblyHierarchy { get; set; }
        public string AssemblyHierarchyTop { get; set; }
        public string AssemblyName { get; set; }
        public string AssemblyNameTop { get; set; }
        public string BlnameApp { get; set; }
        public string BlnameType { get; set; }
        public string ErecId { get; set; }
        public string MainErecId { get; set; }
        public string SubOrderInOptionStdId { get; set; }
        public string SubOrderInOption { get; set; }
        public string OperationOrder { get; set; }
        public string EstimateId { get; set; }
        public string EstimateUserId { get; set; }
        public string PartId { get; set; }
        public string EstPart { get; set; }
        public int? QtyPosition { get; set; }
        public string StdId { get; set; }
        public string StdUserIdandLg { get; set; }
        public string StandardUserId { get; set; }
        public string StdDesc { get; set; }
        public int? NumOut { get; set; }
        public string GenPlanInfo { get; set; }
        public string PartPlanInfo { get; set; }
        public string MfgItemDesc { get; set; }
        public string MfgItemDescLowLevel { get; set; }
        public string OperationId { get; set; }
        public string OpDesc { get; set; }
        public string OpComment { get; set; }
        public bool? IncludeInMarginalCost { get; set; }
        public decimal? EstSetHr { get; set; }
        public decimal? ProdStdHr { get; set; }
        public decimal? MarginalProdHr { get; set; }
        public decimal? SetupShts { get; set; }
        public bool? IsPriceOverridden { get; set; }
        public decimal? RelativePrice { get; set; }
        public decimal? StdMarkup { get; set; }
        public decimal? CostNoMarkup { get; set; }
        public decimal? CostStdMarkup { get; set; }
        public decimal? StdMarkupOnly { get; set; }
        public decimal? MarginalCostStdMarkup { get; set; }
        public string TotalHrSel { get; set; }
        public decimal? TotalHr { get; set; }
        public bool? IsTop { get; set; }
        public bool? IsLg { get; set; }
        public bool? IsLyt { get; set; }
        public string ParentId { get; set; }
        public bool? BelongToMfgplan { get; set; }
        public bool? ConsiderInResults { get; set; }
        public bool? ExportToJob { get; set; }
        public int? ConsiderInResultsInt { get; set; }
        public decimal? QtyPer { get; set; }
        public decimal? EstScrap { get; set; }
        public string EstScrapType { get; set; }
        public decimal? ProdStd { get; set; }
        public decimal? QtyTotal { get; set; }
        public decimal? QtyNet { get; set; }
        public decimal? SetupCrewSize { get; set; }
        public decimal? ProdQty { get; set; }
        public decimal? ScrapQty { get; set; }
        public decimal? RunQty { get; set; }
        public string OperCountUom { get; set; }
        public decimal? ConversionToIum { get; set; }
        public decimal? SheetsIn { get; set; }
        public decimal? SheetsOut { get; set; }
        public decimal? EstProdHr { get; set; }
        public string OperationDescription { get; set; }
        public string EstimateDescription { get; set; }
        public string PartNum { get; set; }
        public string Description { get; set; }
        public decimal? EstUnitCost { get; set; }
        public decimal? DaysOut { get; set; }
        public string Ium { get; set; }
        public int? VendorNum { get; set; }
        public bool? SubContract { get; set; }
        public int? SubContractInt { get; set; }
        public bool? IsUni { get; set; }
        public decimal? StandardType { get; set; }
        public string StdTypeId { get; set; }
        public string CommentFixedSpace { get; set; }
        public string AnalysisCode { get; set; }
        public bool? ConsolidateResByStdType { get; set; }
        public int? OptionIdSttc { get; set; }
        public int? BlnameTypeOvrd { get; set; }
        public int? EstimateIdSttc { get; set; }
        public int? PartIdSttc { get; set; }
        public int? OpCommentOvrd { get; set; }
        public int? RelativePriceOvrd { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public string UserChar1 { get; set; }
        public string UserChar2 { get; set; }
        public string UserChar3 { get; set; }
        public string UserChar4 { get; set; }
        public DateTime? UserDate1 { get; set; }
        public DateTime? UserDate2 { get; set; }
        public DateTime? UserDate3 { get; set; }
        public DateTime? UserDate4 { get; set; }
        public decimal? UserDecimal1 { get; set; }
        public decimal? UserDecimal2 { get; set; }
        public decimal? UserDecimal3 { get; set; }
        public decimal? UserDecimal4 { get; set; }
        public decimal? UserDecimal5 { get; set; }
        public decimal? UserDecimal6 { get; set; }
        public decimal? UserDecimal7 { get; set; }
        public decimal? UserDecimal8 { get; set; }
        public int? UserInteger1 { get; set; }
        public int? UserInteger2 { get; set; }
        public int? UserInteger3 { get; set; }
        public int? UserInteger4 { get; set; }

        public virtual EsMpoptions Option { get; set; }
        public virtual ICollection<EsEstimateopdtl> EsEstimateopdtl { get; set; }
    }
}
