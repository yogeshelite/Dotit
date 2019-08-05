using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpactDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int ActId { get; set; }
        public int DtailId { get; set; }
        public int Paperiod { get; set; }
        public decimal EstCrewSize { get; set; }
        public decimal EstProdQty { get; set; }
        public decimal EstScrapQty { get; set; }
        public decimal EstNonConfQty { get; set; }
        public decimal EstReworkQty { get; set; }
        public decimal ActCrewSize { get; set; }
        public decimal ActProdQty { get; set; }
        public decimal ActScrapQty { get; set; }
        public decimal ActNonConfQty { get; set; }
        public decimal ActReworkQty { get; set; }
        public int EndTime { get; set; }
        public string ActComment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
