using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlRptRow
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int LineNum { get; set; }
        public string LineType { get; set; }
        public string Description { get; set; }
        public string TotalTo { get; set; }
        public string PrintTotal { get; set; }
        public bool Reverse { get; set; }
        public bool NewPage { get; set; }
        public int SkipBefore { get; set; }
        public int SkipAfter { get; set; }
        public int Indents { get; set; }
        public bool ClearAfterPrint { get; set; }
        public string TextFont { get; set; }
        public int TextFontSize { get; set; }
        public string TextUnderline { get; set; }
        public string TextBold { get; set; }
        public string TextItalic { get; set; }
        public string DataFont { get; set; }
        public int DataFontSize { get; set; }
        public string DataUnderline { get; set; }
        public string DataBold { get; set; }
        public string DataItalic { get; set; }
        public int RatioLine1 { get; set; }
        public int RatioLine2 { get; set; }
        public string Category { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
