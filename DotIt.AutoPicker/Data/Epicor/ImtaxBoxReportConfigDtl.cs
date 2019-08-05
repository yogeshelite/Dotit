using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImtaxBoxReportConfigDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public int LineNum { get; set; }
        public string ReportLineNumCaption { get; set; }
        public string ReportLineCaption { get; set; }
        public string FormulaType { get; set; }
        public string Formula { get; set; }
        public bool Hidden { get; set; }
        public bool SuppressNegValue { get; set; }
        public bool SuppressZeroValue { get; set; }
        public string ManualTaxBox { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
