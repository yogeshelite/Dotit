using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class EccdocType
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string ExtSystemId { get; set; }
        public int Eccid { get; set; }
        public string DocTypeId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtCompanyEcc ExtCompanyEcc { get; set; }
    }
}
