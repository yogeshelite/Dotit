﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImudcodeType
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string CodeTypeId { get; set; }
        public string CodeTypeDesc { get; set; }
        public string LongDesc { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public bool AutoSequence { get; set; }
        public int SequenceId { get; set; }
        public string Cgccode { get; set; }
        public bool GlobalUdcodeType { get; set; }
        public bool GlobalLock { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
