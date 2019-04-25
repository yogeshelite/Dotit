using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlcurBal
    {
        public string Company { get; set; }
        public string BookId { get; set; }
        public string DocCurrency { get; set; }
        public string CurrBalAcct { get; set; }
        public int FiscalYear { get; set; }
        public int FiscalPeriod { get; set; }
        public string SegValue1 { get; set; }
        public string SegValue2 { get; set; }
        public string SegValue3 { get; set; }
        public string SegValue4 { get; set; }
        public string SegValue5 { get; set; }
        public string SegValue6 { get; set; }
        public string SegValue7 { get; set; }
        public string SegValue8 { get; set; }
        public string SegValue9 { get; set; }
        public string SegValue10 { get; set; }
        public string SegValue11 { get; set; }
        public string SegValue12 { get; set; }
        public string SegValue13 { get; set; }
        public string SegValue14 { get; set; }
        public string SegValue15 { get; set; }
        public string SegValue16 { get; set; }
        public string SegValue17 { get; set; }
        public string SegValue18 { get; set; }
        public string SegValue19 { get; set; }
        public string SegValue20 { get; set; }
        public decimal DocDebitAmt { get; set; }
        public decimal DocCreditAmt { get; set; }
        public decimal BaseDebitAmt { get; set; }
        public decimal BaseCreditAmt { get; set; }
        public string FiscalYearSuffix { get; set; }
        public string FiscalCalendarId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
