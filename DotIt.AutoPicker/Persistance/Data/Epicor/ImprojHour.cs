using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprojHour
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string ProjectId { get; set; }
        public string Jcdept { get; set; }
        public string DeptDescription { get; set; }
        public decimal EstBurHours { get; set; }
        public decimal EstLbrHours { get; set; }
        public decimal QuotedBurHours { get; set; }
        public decimal QuotedLbrHours { get; set; }
        public decimal ActBurHours { get; set; }
        public decimal ActLbrHours { get; set; }
        public decimal EarnedBurHours { get; set; }
        public decimal EarnedLbrHours { get; set; }
        public decimal QuotedLbrCost { get; set; }
        public decimal QuotedBurCost { get; set; }
        public decimal EstLbrCost { get; set; }
        public decimal EstBurCost { get; set; }
        public decimal ActLbrCost { get; set; }
        public decimal ActBurCost { get; set; }
        public decimal EarnedLbrCost { get; set; }
        public decimal EarnedBurCost { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
