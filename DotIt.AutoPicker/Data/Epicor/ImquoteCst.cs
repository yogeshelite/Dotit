using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImquoteCst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int QtyNum { get; set; }
        public decimal TotalMtlCost { get; set; }
        public decimal TotalLbrCost { get; set; }
        public decimal TotalBurCost { get; set; }
        public decimal TotalSubCost { get; set; }
        public decimal TotalMtlBurCost { get; set; }
        public decimal TotalSetupLbrHrs { get; set; }
        public decimal TotalSetupBurHrs { get; set; }
        public decimal TotalProdLbrHrs { get; set; }
        public decimal TotalProdBurHrs { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
