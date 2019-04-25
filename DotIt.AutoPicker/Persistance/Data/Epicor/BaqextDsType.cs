using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class BaqextDsType
    {
        public string Company { get; set; }
        public string DatasourceType { get; set; }
        public string Description { get; set; }
        public string SampleDatasourceName { get; set; }
        public string ApplicationType { get; set; }
        public int CompanyVisibility { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
