using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WaveOrder
    {
        public string Company { get; set; }
        public int WaveNum { get; set; }
        public int OrderNum { get; set; }
        public int OrderLine { get; set; }
        public int OrderRelNum { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string TfordNum { get; set; }
        public int TfordLine { get; set; }
        public int WaveOrderSeq { get; set; }
        public bool BulkPickComplete { get; set; }
        public bool PickComplete { get; set; }
        public decimal WaveQty { get; set; }
        public string WaveUm { get; set; }
        public string SysShortChar01 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
