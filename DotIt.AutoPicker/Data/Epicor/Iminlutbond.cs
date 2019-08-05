using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Iminlutbond
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string Plant { get; set; }
        public string BondLutnumber { get; set; }
        public DateTime BondYear { get; set; }
        public string BondLuttype { get; set; }
        public DateTime? BondLutdate { get; set; }
        public DateTime? BondLutexpiryDate { get; set; }
        public decimal BondLutvalue { get; set; }
        public bool Status { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
