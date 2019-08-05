using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class RlsGroup
    {
        public string Company { get; set; }
        public string RlsClassCode { get; set; }
        public int TopCustNum { get; set; }
        public int UnTieredGroup { get; set; }
        public bool GlobalNa { get; set; }
        public bool IsCreditUpdated { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
