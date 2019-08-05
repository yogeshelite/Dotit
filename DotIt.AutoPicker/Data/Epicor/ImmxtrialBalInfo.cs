﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImmxtrialBalInfo
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string BookId { get; set; }
        public int FiscalYear { get; set; }
        public string FiscalYearSuffix { get; set; }
        public int FiscalPeriodStart { get; set; }
        public int FiscalPeriodEnd { get; set; }
        public DateTime? PostDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
