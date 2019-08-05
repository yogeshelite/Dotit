﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpcMtlChg
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
        public string AltMethod { get; set; }
        public int MtlSeq { get; set; }
        public int ChgSeq { get; set; }
        public int RelatedOperation { get; set; }
        public string MtlPartNum { get; set; }
        public int OrigRelatedOperation { get; set; }
        public int OrigMtlSeq { get; set; }
        public string OrigMtlPartNum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public Guid BomelementSysRowId { get; set; }
    }
}