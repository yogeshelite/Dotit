using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglRptMas
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
        public string Description { get; set; }
        public string ReportTitle { get; set; }
        public int PctCalcTlLine { get; set; }
        public string HeadingFont { get; set; }
        public int HeadingFontSize { get; set; }
        public bool HeadingUnderline { get; set; }
        public bool HeadingBold { get; set; }
        public bool HeadingItalic { get; set; }
        public string ReportFont { get; set; }
        public int ReportFontSize { get; set; }
        public bool ReportUnderline { get; set; }
        public bool ReportBold { get; set; }
        public bool ReportItalic { get; set; }
        public int AmountFactor { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public string BalanceLevel { get; set; }
        public string BalanceFrequency { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
