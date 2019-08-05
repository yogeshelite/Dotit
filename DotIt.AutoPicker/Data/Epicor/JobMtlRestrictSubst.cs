﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class JobMtlRestrictSubst
    {
        public string Company { get; set; }
        public string JobNum { get; set; }
        public int AssemblySeq { get; set; }
        public int MtlSeq { get; set; }
        public string RestrictionTypeId { get; set; }
        public string SubstanceId { get; set; }
        public decimal Weight { get; set; }
        public string WeightUom { get; set; }
        public bool Manual { get; set; }
        public DateTime? ExemptDate { get; set; }
        public string ExemptCertificate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
