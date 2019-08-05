using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Coamap
    {
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
