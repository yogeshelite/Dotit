using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImsalesTer
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TerritoryId { get; set; }
        public string TerritoryDesc { get; set; }
        public string RegionCode { get; set; }
        public string Comment { get; set; }
        public bool Inactive { get; set; }
        public string PrimeSalesRepCode { get; set; }
        public string DefTaskSetId { get; set; }
        public bool ConsToPrim { get; set; }
        public string PrimeBillingTypeCd { get; set; }
        public bool GlobalSalesTer { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
