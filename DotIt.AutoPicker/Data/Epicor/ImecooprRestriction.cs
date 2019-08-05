﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImecooprRestriction
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public string AltMethod { get; set; }
        public int OprSeq { get; set; }
        public string RestrictionTypeId { get; set; }
        public string OpCode { get; set; }
        public int OrigOprSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}