using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PartAlloc
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
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
        public decimal ReservedQty { get; set; }
        public decimal AllocatedQty { get; set; }
        public decimal PickingQty { get; set; }
        public decimal PickedQty { get; set; }
        public string DemandType { get; set; }
        public string DistributionType { get; set; }
        public DateTime? CreateDate { get; set; }
        public int CreateTime { get; set; }
        public int WaveNum { get; set; }
        public string WaveDestBinNum { get; set; }
        public bool WavePickTicketPrinted { get; set; }
        public string ZoneId { get; set; }
        public string SearchSort { get; set; }
        public string BinType { get; set; }
        public string BinNumFirstOption { get; set; }
        public string WhseDestWarehouseCode { get; set; }
        public string WhseGroupCode { get; set; }
        public int TransPriority { get; set; }
        public bool CrossDocking { get; set; }
        public bool OnHold { get; set; }
        public bool MultiplePartsPerBin { get; set; }
        public string PackStation { get; set; }
        public string BinNumProductionIn { get; set; }
        public string ForwardStageGroup { get; set; }
        public bool HardAllocation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Pcid { get; set; }
    }
}
