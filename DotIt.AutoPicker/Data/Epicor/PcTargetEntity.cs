﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcTargetEntity
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string TableName { get; set; }
        public bool AllowRecordCreation { get; set; }
        public bool AllowPricing { get; set; }
        public bool PromptForConfig { get; set; }
        public bool IncomingSmartString { get; set; }
        public bool AllowReconfig { get; set; }
        public bool Sivalues { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
