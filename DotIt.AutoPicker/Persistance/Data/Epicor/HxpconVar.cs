using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class HxpconVar
    {
        public int Revision { get; set; }
        public string Company { get; set; }
        public DateTime? DateEntered { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string EnteredBy { get; set; }
        public string ProjectId { get; set; }
        public string VarRefId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
