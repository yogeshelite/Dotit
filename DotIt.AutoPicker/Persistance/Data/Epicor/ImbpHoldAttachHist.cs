using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImbpHoldAttachHist
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string HoldTypeId { get; set; }
        public int HoldHistoryId { get; set; }
        public string CreateUserId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string Comment { get; set; }
        public string RemoveUserId { get; set; }
        public DateTime? RemovedOn { get; set; }
        public Guid HoldSysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
