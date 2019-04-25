using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IminvcDtlRasch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int InvoiceNum { get; set; }
        public int InvoiceLine { get; set; }
        public int AmortSeq { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public DateTime? AmortDate { get; set; }
        public decimal AmortPercent { get; set; }
        public decimal AmortAmt { get; set; }
        public decimal Rpt1AmortAmt { get; set; }
        public decimal Rpt2AmortAmt { get; set; }
        public decimal Rpt3AmortAmt { get; set; }
        public decimal DocAmortAmount { get; set; }
        public bool Hold { get; set; }
        public string HoldReasonCode { get; set; }
        public string HoldText { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public int ContractNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int OrgAmortSeq { get; set; }
        public int OrgInvcLine { get; set; }
    }
}
