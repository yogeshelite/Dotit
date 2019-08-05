﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QuoteOprRestriction
    {
        public string Company { get; set; }
        public int QuoteNum { get; set; }
        public int QuoteLine { get; set; }
        public int AssemblySeq { get; set; }
        public int OprSeq { get; set; }
        public string RestrictionTypeId { get; set; }
        public string OpCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}