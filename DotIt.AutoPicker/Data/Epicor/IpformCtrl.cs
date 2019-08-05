using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IpformCtrl
    {
        public string ControlId { get; set; }
        public string FormId { get; set; }
        public string DataSource { get; set; }
        public string ControlLabel { get; set; }
        public string ControlFormat { get; set; }
        public bool Mandatory { get; set; }
        public string DefaultValue { get; set; }
        public int DisplayOrder { get; set; }
        public string ControlType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
