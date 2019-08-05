using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class UserNotificationOption
    {
        public UserNotificationOption()
        {
            UserNotification = new HashSet<UserNotification>();
        }

        public string UserId { get; set; }
        public string Category { get; set; }
        public string NotificationType { get; set; }
        public bool ReceiveNotification { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual UserFile User { get; set; }
        public virtual ICollection<UserNotification> UserNotification { get; set; }
    }
}
