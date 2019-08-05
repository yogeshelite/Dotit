﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImintTransIn
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public string DbschemaName { get; set; }
        public string DbtableName { get; set; }
        public string DbfieldName { get; set; }
        public string DbfieldValue { get; set; }
        public string InboundValue { get; set; }
        public bool DefaultValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}