using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imcoamap
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int CoamapUid { get; set; }
        public string DisplayName { get; set; }
        public string DetailedDescription { get; set; }
        public string SourceCoa { get; set; }
        public string TargetCoa { get; set; }
        public int MapType { get; set; }
        public string Company { get; set; }
        public string TgtCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool GlobalCoasegmentTransform { get; set; }
        public string ExtCompanyId { get; set; }
    }
}
