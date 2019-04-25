using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImtaxSvcConfig
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
