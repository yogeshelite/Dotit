using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ControlSetting
    {
        public string Company { get; set; }
        public string SearchForm { get; set; }
        public string Nsid { get; set; }
        public string UserId { get; set; }
        public string CalledFrom { get; set; }
        public string ControlGuid { get; set; }
        public string ControlValue { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
