using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AltCenter
    {
        public string Company { get; set; }
        public string ResourceGrpId { get; set; }
        public string AltResourceGrpId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
