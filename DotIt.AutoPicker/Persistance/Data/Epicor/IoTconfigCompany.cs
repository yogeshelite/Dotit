using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class IoTconfigCompany
    {
        public string Company { get; set; }
        public string IoThubName { get; set; }
        public string AssignedCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual IoTconfig IoTconfig { get; set; }
    }
}
