using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BpTypeInfo
    {
        public string TypeName { get; set; }
        public string Assembly { get; set; }
        public int WellKnownType { get; set; }
        public string TypeInfo { get; set; }
        public bool Obsolete { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
