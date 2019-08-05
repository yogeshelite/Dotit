﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImkanBanRcptSnformat
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ReceiptId { get; set; }
        public string PartNum { get; set; }
        public string Plant { get; set; }
        public string Snformat { get; set; }
        public string SnbaseDataType { get; set; }
        public string Snprefix { get; set; }
        public string Snmask { get; set; }
        public string SnmaskSuffix { get; set; }
        public string SnmaskPrefix { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
