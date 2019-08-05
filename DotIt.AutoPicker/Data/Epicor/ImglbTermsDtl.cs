﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbTermsDtl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public decimal DiscountPercent { get; set; }
        public int DueOnDay { get; set; }
        public int MinimumDays { get; set; }
        public decimal NumberOfDays { get; set; }
        public decimal NumberOfMonths { get; set; }
        public string TermsCode { get; set; }
        public int TermsSeq { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTermsCode { get; set; }
        public int GlbTermsSeq { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTermsDtl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
