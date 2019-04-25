using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Bvrule
    {
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
