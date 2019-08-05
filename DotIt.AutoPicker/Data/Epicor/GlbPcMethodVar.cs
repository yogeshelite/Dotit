﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbPcMethodVar
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int VarNum { get; set; }
        public string VarName { get; set; }
        public string DataType { get; set; }
        public string Expression { get; set; }
        public string ExprType { get; set; }
        public int VarSeq { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}