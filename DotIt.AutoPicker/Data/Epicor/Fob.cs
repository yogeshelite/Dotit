using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Fob
    {
        public string Company { get; set; }
        public string Fob1 { get; set; }
        public string Description { get; set; }
        public string DeliveryTerms { get; set; }
        public bool GlobalFob { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool InActive { get; set; }
    }
}
