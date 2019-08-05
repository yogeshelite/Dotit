﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImbpSetting
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string BpSettingId { get; set; }
        public byte BpType { get; set; }
        public bool? BitValue { get; set; }
        public int? IntValue { get; set; }
        public string TextValue { get; set; }
        public string Xmlvalue { get; set; }
        public byte[] BlobValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
