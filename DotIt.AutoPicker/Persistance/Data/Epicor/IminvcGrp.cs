using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IminvcGrp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string CreatedBy { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string ActiveUserId { get; set; }
        public string PostErrorLog { get; set; }
        public bool PostInProcess { get; set; }
        public bool UpdateInvAutoPrint { get; set; }
        public bool AutoPrintReady { get; set; }
        public bool AutoPrintEdionly { get; set; }
        public DateTime? ApplyDate { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Boepost { get; set; }
        public bool IsBoe { get; set; }
        public string CashGroupId { get; set; }
    }
}
