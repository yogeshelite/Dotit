﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imzkey
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string KeyId { get; set; }
        public string Description { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool SystemFlag { get; set; }
        public bool External { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
