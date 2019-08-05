using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PkgControlCustPartNum
    {
        public string Company { get; set; }
        public string Pcid { get; set; }
        public long PcidcustPartSeq { get; set; }
        public string CustPartNum { get; set; }
        public decimal CustQtyPerContainer { get; set; }
        public long CustNumContainers { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual PkgControlHeader PkgControlHeader { get; set; }
    }
}
