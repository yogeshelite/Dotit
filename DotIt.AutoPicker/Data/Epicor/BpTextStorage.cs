using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpTextStorage
    {
        public string Company { get; set; }
        public string BpTextStorageGroupCode { get; set; }
        public string BpTextStorageCode { get; set; }
        public string Data { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
