using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteOpDtl
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal SetupHours { get; set; }
        public decimal ProdHours { get; set; }
        public int NumResources { get; set; }
        public decimal SetupBurRate { get; set; }
        public decimal ProdBurRate { get; set; }
        public decimal SetupLabRate { get; set; }
        public decimal ProdLabRate { get; set; }
        public string SetupOrProd { get; set; }
        public string OpDtlDesc { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string StdBasis { get; set; }
        public int OpsPerPart { get; set; }
        public bool OverrideRates { get; set; }
        public decimal ConcurrentCapacity { get; set; }
        public decimal DailyProdRate { get; set; }
        public decimal SetUpCrewSize { get; set; }
        public decimal ProdCrewSize { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal QtyPerCycle { get; set; }
    }
}
