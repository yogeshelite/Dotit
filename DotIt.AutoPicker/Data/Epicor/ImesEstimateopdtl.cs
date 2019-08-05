using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImesEstimateopdtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string RecId { get; set; }
        public string BlnameApp { get; set; }
        public string ErecId { get; set; }
        public string MainErecId { get; set; }
        public string EstimateOperationRecId { get; set; }
        public string InlineErecId { get; set; }
        public bool? ValidOpDtl { get; set; }
        public string OpDtlDesc { get; set; }
        public string ResGroupId { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceRgid { get; set; }
        public string CapabilityRgid { get; set; }
        public decimal? ProdBurRate { get; set; }
        public decimal? SetupBurRate { get; set; }
        public decimal? ProdLaborRate { get; set; }
        public decimal? SetupLaborRate { get; set; }
        public decimal? TotalSetupLaborRate1 { get; set; }
        public decimal? TotalProdLaborRate1 { get; set; }
        public decimal? SetupBurdenCost { get; set; }
        public decimal? ProdBurdenCost { get; set; }
        public decimal? SetupLaborCost { get; set; }
        public decimal? ProdLaborCost { get; set; }
        public decimal? TotalSetupLaborRate { get; set; }
        public decimal? TotalProdLaborRate { get; set; }
        public bool? ConsiderInResults { get; set; }
        public bool? ExportToJob { get; set; }
        public int? ConsiderInResultsInt { get; set; }
        public string HelpSetProdBoth { get; set; }
        public int? Counter { get; set; }
        public bool? IsPrimaryProd { get; set; }
        public bool? IsPrimarySetup { get; set; }
        public string StdUserId { get; set; }
        public string OpCode { get; set; }
        public int? OpDtlSeq { get; set; }
        public bool? IsFinishingHelper { get; set; }
        public decimal? ProdCrewSize { get; set; }
        public decimal? SetupCrewSize { get; set; }
        public string SetupOrProd { get; set; }
        public string EstimateId { get; set; }
        public string Plant { get; set; }
        public int? RowVersion { get; set; }
        public int? TableVersion { get; set; }
        public string EstimateUserId { get; set; }
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
        public decimal? TotalOpDtlCost { get; set; }
    }
}
