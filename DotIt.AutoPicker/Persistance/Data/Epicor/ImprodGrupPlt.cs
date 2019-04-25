using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImprodGrupPlt
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ProdCode { get; set; }
        public string OwnerPlant { get; set; }
        public string SupplyPlant { get; set; }
        public string Planner { get; set; }
        public string JobCompletionCode { get; set; }
        public string JobClosingCode { get; set; }
        public bool GlobalProdGrupPlt { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
