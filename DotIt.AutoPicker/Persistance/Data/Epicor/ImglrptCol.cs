using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImglrptCol
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string ColSetId { get; set; }
        public int ColumnNum { get; set; }
        public bool ShowAsPercent { get; set; }
        public int VarCol1 { get; set; }
        public int VarCol2 { get; set; }
        public int TotalCol1 { get; set; }
        public int TotalCol2 { get; set; }
        public string ColumnTitle1 { get; set; }
        public string ColumnTitle2 { get; set; }
        public string ColumnType { get; set; }
        public int YearOffset { get; set; }
        public int PeriodOffset { get; set; }
        public int NumOfPeriods { get; set; }
        public bool RollingPeriods { get; set; }
        public string TitleFont { get; set; }
        public int TitleFontSize { get; set; }
        public string TitleUnderline { get; set; }
        public string TitleBold { get; set; }
        public string TitleItalic { get; set; }
        public string DataFont { get; set; }
        public int DataFontSize { get; set; }
        public string DataUnderline { get; set; }
        public string DataBold { get; set; }
        public string DataItalic { get; set; }
        public bool DailyAveBalance { get; set; }
        public int NumOfDays { get; set; }
        public int DaysOffset { get; set; }
        public string IntervalType { get; set; }
        public bool RollingDays { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool OverrideBudgetCode { get; set; }
        public string BudgetCodeId { get; set; }
    }
}
