using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImcustGrup
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupCode { get; set; }
        public string GroupDesc { get; set; }
        public string SalesCatId { get; set; }
        public bool GlobalCustGrup { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
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
    }
}
