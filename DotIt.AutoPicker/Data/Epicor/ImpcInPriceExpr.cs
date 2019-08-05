﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcInPriceExpr
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
        public string UsedIn { get; set; }
        public string InputName { get; set; }
        public string InValue { get; set; }
        public bool AllValues { get; set; }
        public int PriceHedSeq { get; set; }
        public int SeqNum { get; set; }
        public string Expression { get; set; }
        public string TypeCode { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
