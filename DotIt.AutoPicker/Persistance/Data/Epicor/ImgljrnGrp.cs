using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImgljrnGrp
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
        public string BookMode { get; set; }
        public string BookId { get; set; }
        public string CurrencyCode { get; set; }
        public string RateGrpCode { get; set; }
        public string CreatedBy { get; set; }
        public string ActiveUserId { get; set; }
        public string PostErrorLog { get; set; }
        public DateTime? Jedate { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string JournalCode { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public string Coacode { get; set; }
        public string FiscalPeriodType { get; set; }
        public int CloseFiscalPeriod { get; set; }
        public bool Posted { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
