﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbrfuncArgs
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int FunctionUid { get; set; }
        public string ArgName { get; set; }
        public string ArgType { get; set; }
        public string Prgname { get; set; }
        public string Prgtype { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public int ArgumentUid { get; set; }
        public string Company { get; set; }
        public bool IsDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
