using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PlntTranDef
    {
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
