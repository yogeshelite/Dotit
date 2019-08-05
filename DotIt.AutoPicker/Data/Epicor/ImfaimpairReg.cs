using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImfaimpairReg
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string AssetNum { get; set; }
        public int ImpairNum { get; set; }
        public string AssetRegId { get; set; }
        public decimal ImpairmentCost { get; set; }
        public decimal DocImpairmentCost { get; set; }
        public decimal Rpt1ImpairmentCost { get; set; }
        public decimal Rpt2ImpairmentCost { get; set; }
        public decimal Rpt3ImpairmentCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
