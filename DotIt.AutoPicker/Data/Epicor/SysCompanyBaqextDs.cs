using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class SysCompanyBaqextDs
    {
        public string Company { get; set; }
        public string DatasourceCompany { get; set; }
        public string DatasourceName { get; set; }
        public string FilterGroupName { get; set; }
        public string FilterName { get; set; }
        public bool SkipFilter { get; set; }
        public bool UseDefault { get; set; }
        public string FilterValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
