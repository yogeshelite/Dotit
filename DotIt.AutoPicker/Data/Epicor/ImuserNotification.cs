using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImuserNotification
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string UserId { get; set; }
        public long NotificationNum { get; set; }
        public string Category { get; set; }
        public string NotificationType { get; set; }
        public bool NotificationRead { get; set; }
        public string RelatedToSchemaName { get; set; }
        public string RelatedToTableName { get; set; }
        public Guid RelatedToSysRowId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
