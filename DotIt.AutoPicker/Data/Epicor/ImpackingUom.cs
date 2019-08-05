using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImpackingUom
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string PkgCode { get; set; }
        public string PartNum { get; set; }
        public string UomclassId { get; set; }
        public string Uomcode { get; set; }
        public int PkgDisplaySeq { get; set; }
        public bool PkgIsDefault { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool PkgDisplayHidden { get; set; }
    }
}
