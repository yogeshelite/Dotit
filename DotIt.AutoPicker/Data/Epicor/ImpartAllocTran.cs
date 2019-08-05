using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartAllocTran
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int TranNum { get; set; }
        public string DcdUserId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string WarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string SupplyJobNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public decimal AllocatedQty { get; set; }
        public int WaveNum { get; set; }
        public string WaveDesc { get; set; }
        public string AllocTemplateId { get; set; }
        public string AllocType { get; set; }
        public string DemandType { get; set; }
        public string ZoneId { get; set; }
        public string SearchSort { get; set; }
        public string BinNumFirstOption { get; set; }
        public string DistributionType { get; set; }
        public string WhseGroupCode { get; set; }
        public int TransPriority { get; set; }
        public bool CrossDocking { get; set; }
        public bool MultiplePartsPerBin { get; set; }
        public string PackStation { get; set; }
        public string BinNumProductionIn { get; set; }
        public string ForwardStageGroup { get; set; }
        public string EmpId { get; set; }
        public string BinType { get; set; }
        public bool OnHold { get; set; }
        public string AssignEmpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string WhseDestWarehouseCode { get; set; }
        public bool ReleaseToPicking { get; set; }
        public string Pcid { get; set; }
    }
}
