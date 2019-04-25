using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Dcrmterr
    {
        public string DeviceId { get; set; }
        public string Company { get; set; }
        public string TerritoryId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
