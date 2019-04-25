using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImsysCompanyBaqextDs
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
