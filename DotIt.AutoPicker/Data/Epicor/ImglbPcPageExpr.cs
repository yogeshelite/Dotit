﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbPcPageExpr
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public int PageSeq { get; set; }
        public string ConfigId { get; set; }
        public int SeqNum { get; set; }
        public string TypeCode { get; set; }
        public string Expression { get; set; }
        public string GlbCompany { get; set; }
        public string GlbPartNum { get; set; }
        public string GlbRevisionNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}