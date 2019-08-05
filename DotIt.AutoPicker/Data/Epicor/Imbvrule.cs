using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imbvrule
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int BvruleUid { get; set; }
        public int VruleUid { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string Vlevel { get; set; }
        public string Company { get; set; }
        public string BookId { get; set; }
        public int ActtypeUid { get; set; }
        public int ActrevisionUid { get; set; }
        public int RuleUid { get; set; }
        public bool IsDefault { get; set; }
        public bool LocModified { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
