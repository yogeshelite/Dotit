using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class SecGroup
    {
        public string Company { get; set; }
        public string SecGroupCode { get; set; }
        public string SecGroupDesc { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
