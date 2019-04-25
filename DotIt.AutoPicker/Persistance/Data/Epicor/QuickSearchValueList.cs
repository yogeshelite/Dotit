using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QuickSearchValueList
    {
        public string Company { get; set; }
        public string QuickSearchId { get; set; }
        public string GlbCompany { get; set; }
        public int Seq { get; set; }
        public int ValueSeq { get; set; }
        public string DisplayMember { get; set; }
        public string ValueMember { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual QuickSearchCriteria QuickSearchCriteria { get; set; }
    }
}
