using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EcomtlRefDes
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int MtlSeq { get; set; }
        public string RefDes { get; set; }
        public int RefDesSeq { get; set; }
        public string MtlPartNum { get; set; }
        public int OrigMtlSeq { get; set; }
        public string Side { get; set; }
        public decimal Xlocation { get; set; }
        public decimal Ylocation { get; set; }
        public decimal Zlocation { get; set; }
        public decimal Rotation { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
