using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class OpMasDtl
    {
        public string Company { get; set; }
        public string OpCode { get; set; }
        public int OpDtlSeq { get; set; }
        public string SetupOrProd { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal SetupHours { get; set; }
        public decimal ProdHours { get; set; }
        public int NumResources { get; set; }
        public string OpDtlDesc { get; set; }
        public decimal ConcurrentCapacity { get; set; }
        public decimal DailyProdRate { get; set; }
        public string Plant { get; set; }
        public decimal ProdCrewSize { get; set; }
        public decimal SetUpCrewSize { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool PrimaryProd { get; set; }
        public bool PrimarySetup { get; set; }
    }
}
