using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Vsblock
    {
        public string Company { get; set; }
        public string DcduserId { get; set; }
        public string Type { get; set; }
        public string Plant { get; set; }
        public string ConnectName { get; set; }
        public int ConnectPid { get; set; }
        public string ConnectDevice { get; set; }
        public string SessionId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
