using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JobOpDtl
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public string SetupOrProd { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal ConcurrentCapacity { get; set; }
        public decimal DailyProdRate { get; set; }
        public int NumResources { get; set; }
        public decimal EstSetHours { get; set; }
        public decimal EstProdHours { get; set; }
        public decimal ProdStandard { get; set; }
        public string StdFormat { get; set; }
        public string StdBasis { get; set; }
        public int OpsPerPart { get; set; }
        public decimal ProdLabRate { get; set; }
        public decimal SetupLabRate { get; set; }
        public decimal ProdBurRate { get; set; }
        public decimal SetupBurRate { get; set; }
        public bool ProdComplete { get; set; }
        public bool SetupComplete { get; set; }
        public decimal ActProdHours { get; set; }
        public decimal ActProdRwkHours { get; set; }
        public decimal ActSetupHours { get; set; }
        public decimal ActSetupRwkHours { get; set; }
        public int SetupPctComplete { get; set; }
        public decimal ActBurCost { get; set; }
        public decimal ActLabCost { get; set; }
        public decimal ReworkBurCost { get; set; }
        public decimal ReworkLabCost { get; set; }
        public bool ResourceLock { get; set; }
        public DateTime? SysCreateDate { get; set; }
        public int SysCreateTime { get; set; }
        public string OpDtlDesc { get; set; }
        public decimal EstSetHoursPerMch { get; set; }
        public bool OverrideRates { get; set; }
        public decimal ProdCrewSize { get; set; }
        public decimal SetUpCrewSize { get; set; }
        public bool RemovedFromPlan { get; set; }
        public bool IsPrimaryProd { get; set; }
        public bool IsPrimarySetup { get; set; }
        public bool AutoSystemAdded { get; set; }
        public bool MobileAllocatedResource { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal QtyPerCycle { get; set; }
    }
}
