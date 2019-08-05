using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PcPropBagDtl
    {
        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string BagId { get; set; }
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyField { get; set; }
        public string DataType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PcPropBagDef PcPropBagDef { get; set; }
    }
}
