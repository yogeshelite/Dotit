using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbTariffComm
    {
        public string CommodityCode { get; set; }
        public string Company { get; set; }
        public string TariffCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbTariffCode { get; set; }
        public string GlbCommodityCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalTariffComm { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
