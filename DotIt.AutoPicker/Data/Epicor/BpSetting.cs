using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpSetting
    {
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
