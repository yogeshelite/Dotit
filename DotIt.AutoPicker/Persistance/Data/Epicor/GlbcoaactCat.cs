using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbcoaactCat
    {
        public string Company { get; set; }
        public string ExtCompanyId { get; set; }
        public string Coacode { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string NormalBalance { get; set; }
        public string ParentCategory { get; set; }
        public int Sequence { get; set; }
        public string ConsolidationType { get; set; }
        public bool NetIncome { get; set; }
        public bool MatchingEnabled { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool CnisCashBank { get; set; }
    }
}
