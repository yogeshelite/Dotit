using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImecoopDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int OprSeq { get; set; }
        public int OpDtlSeq { get; set; }
        public string CapabilityId { get; set; }
        public string ResourceGrpId { get; set; }
        public string ResourceId { get; set; }
        public decimal SetupHours { get; set; }
        public decimal ProdHours { get; set; }
        public int NumResources { get; set; }
        public string SetupOrProd { get; set; }
        public string AltMethod { get; set; }
        public string OpDtlDesc { get; set; }
        public string ParentAltMethod { get; set; }
        public int ParentOprSeq { get; set; }
        public int ParentOpDtlSeq { get; set; }
        public bool BaseMethodOverridden { get; set; }
        public int OrigOpDtlSeq { get; set; }
        public int OrigOprSeq { get; set; }
        public decimal ConcurrentCapacity { get; set; }
        public decimal DailyProdRate { get; set; }
        public decimal ProdCrewSize { get; set; }
        public decimal SetUpCrewSize { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
