using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpartMtlRefDes
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int MtlSeq { get; set; }
        public string RefDes { get; set; }
        public int RefDesSeq { get; set; }
        public string MtlPartNum { get; set; }
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
