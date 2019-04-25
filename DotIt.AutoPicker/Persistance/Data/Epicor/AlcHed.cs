using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcHed
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public string Description { get; set; }
        public int AllocationType { get; set; }
        public string BookId { get; set; }
        public int Tier { get; set; }
        public string PriorTgtStamp { get; set; }
        public string TgtStamp { get; set; }
        public string SrcAllocStamp { get; set; }
        public bool IgnoreStamp { get; set; }
        public bool UseAllStamps { get; set; }
        public string Coacode { get; set; }
        public int AllocOption { get; set; }
        public decimal PercentToAlloc { get; set; }
        public bool UseAllocUnits { get; set; }
        public string OffsetAcct { get; set; }
        public string OffsetSegVal1 { get; set; }
        public string OffsetSegVal2 { get; set; }
        public string OffsetSegVal3 { get; set; }
        public string OffsetSegVal4 { get; set; }
        public string OffsetSegVal5 { get; set; }
        public string OffsetSegVal6 { get; set; }
        public string OffsetSegVal7 { get; set; }
        public string OffsetSegVal8 { get; set; }
        public string OffsetSegVal9 { get; set; }
        public string OffsetSegVal10 { get; set; }
        public string OffsetSegVal11 { get; set; }
        public string OffsetSegVal12 { get; set; }
        public string OffsetSegVal13 { get; set; }
        public string OffsetSegVal14 { get; set; }
        public string OffsetSegVal15 { get; set; }
        public string OffsetSegVal16 { get; set; }
        public string OffsetSegVal17 { get; set; }
        public string OffsetSegVal18 { get; set; }
        public string OffsetSegVal19 { get; set; }
        public string OffsetSegVal20 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool StatBalAsAllocUnits { get; set; }
    }
}
