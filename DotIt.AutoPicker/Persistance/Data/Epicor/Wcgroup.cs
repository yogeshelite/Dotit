using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Wcgroup
    {
        public string Company { get; set; }
        public string GroupId { get; set; }
        public string Description { get; set; }
        public string Wclist { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
