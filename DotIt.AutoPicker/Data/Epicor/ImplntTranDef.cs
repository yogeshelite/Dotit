using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImplntTranDef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FromPlant { get; set; }
        public string ToPlant { get; set; }
        public string JournalCode { get; set; }
        public int TranDays { get; set; }
        public string ConsolidationDivision { get; set; }
        public string InterDivSalesCatId { get; set; }
        public string DefaultShipViaCode { get; set; }
        public bool InterDivisional { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
