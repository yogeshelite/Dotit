using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbConsSrcCtrl
    {
        public string Company { get; set; }
        public string GlbCompany { get; set; }
        public int GlbGenId { get; set; }
        public string GlbSourceBook { get; set; }
        public int GenId { get; set; }
        public string SourceBook { get; set; }
        public string FiscalCalendarId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public string ConsDefId { get; set; }
        public DateTime? PostedDate { get; set; }
        public int PostedTime { get; set; }
        public string PostedBy { get; set; }
        public string DiffOnExchangeAcct { get; set; }
        public string GenStatus { get; set; }
        public bool Bypassed { get; set; }
        public string DiffExSegValue1 { get; set; }
        public string DiffExSegValue2 { get; set; }
        public string DiffExSegValue3 { get; set; }
        public string DiffExSegValue4 { get; set; }
        public string DiffExSegValue5 { get; set; }
        public string DiffExSegValue6 { get; set; }
        public string DiffExSegValue7 { get; set; }
        public string DiffExSegValue8 { get; set; }
        public string DiffExSegValue9 { get; set; }
        public string DiffExSegValue10 { get; set; }
        public string DiffExSegValue11 { get; set; }
        public string DiffExSegValue12 { get; set; }
        public string DiffExSegValue13 { get; set; }
        public string DiffExSegValue14 { get; set; }
        public string DiffExSegValue15 { get; set; }
        public string DiffExSegValue16 { get; set; }
        public string DiffExSegValue17 { get; set; }
        public string DiffExSegValue18 { get; set; }
        public string DiffExSegValue19 { get; set; }
        public string DiffExSegValue20 { get; set; }
        public string RemoteAcct { get; set; }
        public string BalanceSheetDefType { get; set; }
        public string IncomeStmtDefType { get; set; }
        public int ClosingPeriods { get; set; }
        public bool ExcludeOpenPrds { get; set; }
        public string TgtJrnlCode { get; set; }
        public bool ReverseDbcr { get; set; }
        public int CoamapUid { get; set; }
        public string IntermediateJrnlCode { get; set; }
        public bool Retransfer { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int AdjustFromFiscalPeriod { get; set; }
        public DateTime? PeriodEndDate { get; set; }
        public DateTime? AdjPeriodEndDate { get; set; }
        public int ProcessedFiscalPeriod { get; set; }
    }
}
