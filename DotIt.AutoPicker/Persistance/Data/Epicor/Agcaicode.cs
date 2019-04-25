using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Agcaicode
    {
        public string Company { get; set; }
        public string EmissionPointId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Cai { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
