using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class IntParamValues
    {
        public Guid ImsysRowId { get; set; }
        public Guid ParamDefSysRowId { get; set; }
        public string ParamValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
