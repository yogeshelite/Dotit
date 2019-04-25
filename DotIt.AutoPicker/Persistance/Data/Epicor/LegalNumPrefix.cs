using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LegalNumPrefix
    {
        public string Company { get; set; }
        public string LegalNumberId { get; set; }
        public string Prefix { get; set; }
        public string Plant { get; set; }
        public string NumberOption { get; set; }
        public bool CnfgDefault { get; set; }
        public string DcdUserId { get; set; }
        public string WarehouseCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
