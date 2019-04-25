using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Ccpcid
    {
        public string Company { get; set; }
        public string Plant { get; set; }
        public string WarehouseCode { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public int CycleSeq { get; set; }
        public string Pcid { get; set; }
        public string ParentPcid { get; set; }
        public string TopLevelPcid { get; set; }
        public bool AddedByBlankTag { get; set; }
        public bool AllocationVariance { get; set; }
        public string BinNum { get; set; }
        public string MoveToCycle { get; set; }
        public DateTime? DateRemoved { get; set; }
        public string RemovedBy { get; set; }
        public int PostAdjustment { get; set; }
        public int PostStatus { get; set; }
        public bool Ccpcidboolean01 { get; set; }
        public bool Ccpcidboolean02 { get; set; }
        public string Ccpcidcharacter01 { get; set; }
        public string Ccpcidcharacter02 { get; set; }
        public string Ccpcidcharacter03 { get; set; }
        public string Ccpcidcharacter04 { get; set; }
        public string Ccpcidcharacter05 { get; set; }
        public DateTime? Ccpciddate01 { get; set; }
        public DateTime? Ccpciddate02 { get; set; }
        public decimal Ccpciddecimal01 { get; set; }
        public decimal Ccpciddecimal02 { get; set; }
        public int Ccpcidinteger01 { get; set; }
        public int Ccpcidinteger02 { get; set; }
        public string MoveToWarehouseCode { get; set; }
        public string MoveToBinNum { get; set; }
        public string AddToPcid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
