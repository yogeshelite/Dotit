using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlctacctCntxt
    {
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public int GlctacctNum { get; set; }
        public string GlacctContext { get; set; }
        public string BookId { get; set; }
        public bool Required { get; set; }
        public bool AllBooks { get; set; }
        public bool UseMasterChart { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
