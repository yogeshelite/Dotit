using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class TaxSvcConfig
    {
        public string Company { get; set; }
        public string Url { get; set; }
        public string ViaUrl { get; set; }
        public string TextCase { get; set; }
        public string Account { get; set; }
        public string Key { get; set; }
        public bool TaxConnectEnabled { get; set; }
        public bool AddrValEnabled { get; set; }
        public bool TaxCalcEnabled { get; set; }
        public string TaxIdPrefix { get; set; }
        public int RequestTimeOut { get; set; }
        public string DefaultTaxCatId { get; set; }
        public int LastDocId { get; set; }
        public bool DebugMode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ValidateIsocode { get; set; }
    }
}
