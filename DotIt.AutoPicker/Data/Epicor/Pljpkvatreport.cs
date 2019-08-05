﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Pljpkvatreport
    {
        public string Company { get; set; }
        public string ReportId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriod { get; set; }
        public int CorrectionSubmit { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
