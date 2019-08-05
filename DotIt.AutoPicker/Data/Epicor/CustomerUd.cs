using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustomerUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool NotifyviaemailC { get; set; }
        public bool NotifyviaprintC { get; set; }
        public string StorenumberC { get; set; }
        public bool ApplyChrOverrideC { get; set; }
        public bool DropShipC { get; set; }
        public bool InactiveC { get; set; }
        public bool InvoiceSummaryC { get; set; }
        public string ArnotesC { get; set; }
        public bool BadDebtC { get; set; }
        public bool IsSupressOrderNotificationC { get; set; }
        public bool YextActiveC { get; set; }
        public bool YextAutoRenewC { get; set; }
        public string YextCustomerNumberC { get; set; }
        public decimal YextFeeC { get; set; }
        public DateTime? YextRenewDateC { get; set; }
        public string YextSsotokenC { get; set; }
        public DateTime? YextStartDateC { get; set; }
        public bool SendShippingNotificationsC { get; set; }
        public string ShipCommentC { get; set; }

        public virtual Customer ForeignSysRow { get; set; }
    }
}
