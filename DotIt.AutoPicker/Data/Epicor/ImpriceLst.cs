using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpriceLst
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ListCode { get; set; }
        public string CurrencyCode { get; set; }
        public string ListDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string WarehouseList { get; set; }
        public bool GlobalPriceLst { get; set; }
        public bool GlobalLock { get; set; }
        public string ListType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool UseZeroPrice { get; set; }
        public bool ExpiredC { get; set; }
    }
}
