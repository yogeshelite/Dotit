using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImgljrnDtlMnlDeasch
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string BookId { get; set; }
        public string JournalCode { get; set; }
        public int JournalNum { get; set; }
        public int JournalLine { get; set; }
        public int AmortSeq { get; set; }
        public string SchFiscalCalendarId { get; set; }
        public int SchFiscalYear { get; set; }
        public string SchFiscalYearSuffix { get; set; }
        public int SchFiscalPeriod { get; set; }
        public DateTime? AmortDate { get; set; }
        public decimal AmortPercent { get; set; }
        public decimal AmortAmt { get; set; }
        public decimal DocAmortAmt { get; set; }
        public bool Posted { get; set; }
        public DateTime? PostedDate { get; set; }
        public string TranDocTypeId { get; set; }
        public string LegalNumber { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal Rpt1AmortAmt { get; set; }
        public decimal Rpt2AmortAmt { get; set; }
        public decimal Rpt3AmortAmt { get; set; }
    }
}
