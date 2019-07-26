using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TaxBoxReportConfigDtl
    {
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

        public virtual TaxBoxReportConfigHead Co { get; set; }
    }
}
