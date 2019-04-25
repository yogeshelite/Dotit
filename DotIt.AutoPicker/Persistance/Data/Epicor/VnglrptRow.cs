using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VnglrptRow
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public string BookId { get; set; }
        public int LineNum { get; set; }
        public bool HiddenFlag { get; set; }
        public string RowItemName { get; set; }
        public string RowItemCode { get; set; }
        public string RowItemNotes { get; set; }
        public string RowAcctType { get; set; }
        public string TextFont { get; set; }
        public int TextFontSize { get; set; }
        public string TextBold { get; set; }
        public string TextItalic { get; set; }
        public string TextUnderline { get; set; }
        public string DataFont { get; set; }
        public int DataFontSize { get; set; }
        public string DataBold { get; set; }
        public string DataItalic { get; set; }
        public string DataUnderline { get; set; }
        public int SkipAfter { get; set; }
        public int SkipBefore { get; set; }
        public int Indents { get; set; }
        public bool NewPage { get; set; }
        public bool Reverse { get; set; }
        public decimal EndingBalance { get; set; }
        public decimal BeginBalance { get; set; }
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public string RowType { get; set; }
        public string Coacode { get; set; }
        public string LineNumAcct { get; set; }
        public string SegmentName { get; set; }
        public int SegmentNumber { get; set; }
        public string DestinationLineNum { get; set; }
        public string ItemValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IsOpening { get; set; }
        public bool IsDebit { get; set; }
        public string FromAccount2 { get; set; }
        public string ToAccount2 { get; set; }

        public virtual VnglrptMaster VnglrptMaster { get; set; }
    }
}
