using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HdcaseType
    {
        public string Company { get; set; }
        public string CaseTypeId { get; set; }
        public string Description { get; set; }
        public string RelatedTo { get; set; }
        public string DefWfgroupId { get; set; }
        public string DefWftype { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
