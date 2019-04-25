using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcPropBagDef
    {
        public PcPropBagDef()
        {
            PcPropBagDtl = new HashSet<PcPropBagDtl>();
        }

        public string Company { get; set; }
        public string ConfigId { get; set; }
        public string BagId { get; set; }
        public string Description { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ICollection<PcPropBagDtl> PcPropBagDtl { get; set; }
    }
}
