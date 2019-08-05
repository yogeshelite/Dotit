﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImtargetValueField
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int TargetValueFieldUid { get; set; }
        public int MapUid { get; set; }
        public int SequenceNumber { get; set; }
        public string FieldName { get; set; }
        public string DetailedDescription { get; set; }
        public string ValueType { get; set; }
        public string Coacode { get; set; }
        public int SegmentNbr { get; set; }
        public bool Validate { get; set; }
        public string Company { get; set; }
        public bool GlobalTargetValueField { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
