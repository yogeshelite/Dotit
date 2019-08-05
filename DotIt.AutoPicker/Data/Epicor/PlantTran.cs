using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PlantTran
    {
        public string Company { get; set; }
        public DateTime? SysDate { get; set; }
        public int SysTime { get; set; }
        public int TranNum { get; set; }
        public string TranStatus { get; set; }
        public string PartNum { get; set; }
        public string PartDescription { get; set; }
        public string RevisionNum { get; set; }
        public string FromPlant { get; set; }
        public string ToPlant { get; set; }
        public string FromWarehouseCode { get; set; }
        public string BinNum { get; set; }
        public string FromJobNum { get; set; }
        public int FromAssemblySeq { get; set; }
        public string WarehseCodeTo { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int JobMtl { get; set; }
        public decimal TranQty { get; set; }
        public DateTime? TranDate { get; set; }
        public string Um { get; set; }
        public string LotNum { get; set; }
        public string DimCode { get; set; }
        public string Dum { get; set; }
        public decimal DimConvFactor { get; set; }
        public string PlntTranReference { get; set; }
        public decimal MtlUnitCost { get; set; }
        public decimal LbrUnitCost { get; set; }
        public decimal BurUnitCost { get; set; }
        public decimal SubUnitCost { get; set; }
        public decimal MtlBurUnitCost { get; set; }
        public string EntryPerson { get; set; }
        public string TranType { get; set; }
        public decimal InternalPrice { get; set; }
        public int PackNum { get; set; }
        public DateTime? RecSysDate { get; set; }
        public int RecSysTime { get; set; }
        public DateTime? RecTranDate { get; set; }
        public string RecEntryPerson { get; set; }
        public bool RecIssuedComplete { get; set; }
        public decimal MtlMtlUnitCost { get; set; }
        public decimal MtlLabUnitCost { get; set; }
        public decimal MtlSubUnitCost { get; set; }
        public decimal MtlBurdenUnitCost { get; set; }
        public decimal MtlMtlBurUnitCost { get; set; }
        public int TfordLine { get; set; }
        public int PackLine { get; set; }
        public string TfordNum { get; set; }
        public string TflineNum { get; set; }
        public decimal AltMtlUnitCost { get; set; }
        public decimal AltLbrUnitCost { get; set; }
        public decimal AltBurUnitCost { get; set; }
        public decimal AltSubUnitCost { get; set; }
        public decimal AltMtlBurUnitCost { get; set; }
        public decimal AltMtlMtlUnitCost { get; set; }
        public decimal AltMtlLabUnitCost { get; set; }
        public decimal AltMtlSubUnitCost { get; set; }
        public decimal AltMtlBurdenUnitCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
