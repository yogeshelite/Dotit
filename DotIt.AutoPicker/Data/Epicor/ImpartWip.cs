using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartWip
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string PartNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public int MtlSeq { get; set; }
        public string WareHouseCode { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public string BinNum { get; set; }
        public string TrackType { get; set; }
        public string ResourceGrpId { get; set; }
        public string OpCode { get; set; }
        public string RevisionNum { get; set; }
        public decimal Quantity { get; set; }
        public string Um { get; set; }
        public int FromAssemblySeq { get; set; }
        public int FromOprSeq { get; set; }
        public string FromResourceGrpId { get; set; }
        public string FromOpCode { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public int LastActivityTime { get; set; }
        public bool FinalOp { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public string UpdateStageQty { get; set; }
        public bool History { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
    }
}
