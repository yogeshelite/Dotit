using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class VnglrptMaster
    {
        public VnglrptMaster()
        {
            VnglrptRow = new HashSet<VnglrptRow>();
        }

        public string Company { get; set; }
        public string ReportId { get; set; }
        public string BookId { get; set; }
        public string Coacode { get; set; }
        public string Description { get; set; }
        public bool HeadingBold { get; set; }
        public string HeadingFont { get; set; }
        public int HeadingFontSize { get; set; }
        public bool HeadingItalic { get; set; }
        public bool HeadingUnderline { get; set; }
        public bool ReportBold { get; set; }
        public string ReportFont { get; set; }
        public int ReportFontSize { get; set; }
        public bool ReportItalic { get; set; }
        public bool ReportUnderline { get; set; }
        public string ReportTemplate { get; set; }
        public string ReportTitle { get; set; }
        public int AmountFactor { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int LineNum { get; set; }
        public int SubLineNum { get; set; }

        public virtual ICollection<VnglrptRow> VnglrptRow { get; set; }
    }
}
