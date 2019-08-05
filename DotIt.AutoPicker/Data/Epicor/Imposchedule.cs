using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imposchedule
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
        public int ContractPonum { get; set; }
        public int ContractPoline { get; set; }
        public int ContractRev { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? PrintedDate { get; set; }
        public DateTime? LastRunDate { get; set; }
        public bool ActiveRevision { get; set; }
        public string PartNum { get; set; }
        public int VendorNum { get; set; }
        public string BuyerId { get; set; }
        public string DevChar01 { get; set; }
        public string DevChar02 { get; set; }
        public string DevChar03 { get; set; }
        public string DevChar04 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
