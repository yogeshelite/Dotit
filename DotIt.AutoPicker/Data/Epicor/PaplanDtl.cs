using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PaplanDtl
    {
        public string Company { get; set; }
        public string PaplanId { get; set; }
        public int PaplanDtlId { get; set; }
        public string PadayId { get; set; }
        public int Paperiod { get; set; }
        public decimal CrewSize { get; set; }
        public decimal EstProdQty { get; set; }
        public decimal EstScrapQty { get; set; }
        public decimal EstNonConfQty { get; set; }
        public decimal EstReworkQty { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
