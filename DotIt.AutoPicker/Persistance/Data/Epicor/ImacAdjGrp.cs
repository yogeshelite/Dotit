using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImacAdjGrp
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal AdjGrpId { get; set; }
        public string GroupCd { get; set; }
        public DateTime? AdjustmentDate { get; set; }
        public DateTime? ApplyDate { get; set; }
        public bool Posted { get; set; }
        public bool PostInProgress { get; set; }
        public string PostErrorLog { get; set; }
        public bool PostingAcctAdj { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public int VendorNum { get; set; }
        public string VendorInvoiceNum { get; set; }
        public string CommentText { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int CreatedTime { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedTime { get; set; }
        public bool Inactive { get; set; }
        public bool Refund { get; set; }
        public string RefundGroupId { get; set; }
        public string RefundBankAcctId { get; set; }
        public int RefundPmuid { get; set; }
        public bool RefundPost { get; set; }
        public string RefundErrorLog { get; set; }
        public Guid SysRowId { get; set; }
        public byte[] SysRevId { get; set; }
        public bool RefundPosting { get; set; }
    }
}
