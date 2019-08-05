using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Eaqchannels
    {
        public string Company { get; set; }
        public string DataId { get; set; }
        public string InputChannelUrl { get; set; }
        public string OutputChannelUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
