using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class LangOrg
    {
        public int OrgTextId { get; set; }
        public int OrgHash { get; set; }
        public string OrgText { get; set; }
        public string SortOrgText { get; set; }
        public bool SystemFlag { get; set; }
        public int? ReferenceId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
