using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DemandOutbound
    {
        public string Company { get; set; }
        public string EdidocCode { get; set; }
        public string EdidocDescription { get; set; }
        public string RptDefId { get; set; }
        public string OutputLocation { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
