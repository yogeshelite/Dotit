using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImccwhsCtrl
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string WarehouseCode { get; set; }
        public string Plant { get; set; }
        public int Ccyear { get; set; }
        public int Ccmonth { get; set; }
        public bool FullPhysical { get; set; }
        public bool ExcludeInactive { get; set; }
        public bool ExcludeOnHold { get; set; }
        public bool ExcludeNegQoh { get; set; }
        public bool ExcludeNoActivity { get; set; }
        public bool PartsSelected { get; set; }
        public bool ExcludeZeroQoh { get; set; }
        public string CcprodCal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool IncludeNonStock { get; set; }
        public bool ExcludePcid { get; set; }
    }
}
