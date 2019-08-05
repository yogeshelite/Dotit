﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcVerRulesExpr
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int ConfigVersion { get; set; }
        public int RuleSeq { get; set; }
        public int OprSeq { get; set; }
        public int MtlSeq { get; set; }
        public string ParPartNum { get; set; }
        public string AsmPartNum { get; set; }
        public string AltMethod { get; set; }
        public int OpDtlSeq { get; set; }
        public int SeqNum { get; set; }
        public string Expression { get; set; }
        public string TypeCode { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}