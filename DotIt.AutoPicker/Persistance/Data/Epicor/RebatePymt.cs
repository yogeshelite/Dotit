using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RebatePymt
    {
        public string Company { get; set; }
        public string RebateId { get; set; }
        public DateTime? PymtDate { get; set; }
        public bool Generated { get; set; }
        public bool Approved { get; set; }
        public bool Pulled { get; set; }
        public bool Appulled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
