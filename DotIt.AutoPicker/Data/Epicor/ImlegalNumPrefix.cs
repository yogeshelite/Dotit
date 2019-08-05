using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImlegalNumPrefix
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string LegalNumberId { get; set; }
        public string Prefix { get; set; }
        public string Plant { get; set; }
        public string NumberOption { get; set; }
        public bool CnfgDefault { get; set; }
        public string DcdUserId { get; set; }
        public string WarehouseCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
