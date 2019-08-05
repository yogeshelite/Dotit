using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Partner
    {
        public string Company { get; set; }
        public int PartnerNum { get; set; }
        public int PartnerType { get; set; }
        public string SearchId { get; set; }
        public bool IsActive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string PartnerId { get; set; }
    }
}
