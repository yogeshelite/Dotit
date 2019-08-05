using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CustGrupUd
    {
        public Guid ForeignSysRowId { get; set; }
        public byte[] UdSysRevId { get; set; }
        public bool AllowBillToEditC { get; set; }
        public bool AllowShipToEditC { get; set; }
        public string ECommUrlC { get; set; }
        public string ParentCustomerGroupC { get; set; }
        public bool AllowAutomaticApprovalC { get; set; }
        public int AutomaticApprovalLapseInMinsC { get; set; }
        public int DotitNotificationLapseInMinsC { get; set; }
        public string EmailDotitNotificationsC { get; set; }
        public bool IsAllPartsC { get; set; }
        public bool IsCompanyWideEscalationC { get; set; }
        public bool IsRequisitionCustomerC { get; set; }
        public int RequisitionNotificationLapseInMinsC { get; set; }
        public int SeniorNotificationLapseInMinsC { get; set; }
        public bool IsBrandFulfillmentC { get; set; }

        public virtual CustGrup ForeignSysRow { get; set; }
    }
}
