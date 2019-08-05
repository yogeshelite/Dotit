using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbFob
    {
        public string Company { get; set; }
        public string DeliveryTerms { get; set; }
        public string Description { get; set; }
        public string Fob { get; set; }
        public string GlbCompany { get; set; }
        public string GlbFob1 { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalFob { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
