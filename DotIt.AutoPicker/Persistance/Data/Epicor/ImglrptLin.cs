using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglrptLin
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string EffCat { get; set; }
        public int SortSeq { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal PerAmt { get; set; }
        public decimal Ytdamt { get; set; }
        public decimal CompAmt { get; set; }
        public decimal CompYtdamt { get; set; }
        public decimal PerVar { get; set; }
        public decimal Ytdvar { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
