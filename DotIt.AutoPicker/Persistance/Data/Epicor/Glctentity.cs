using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Glctentity
    {
        public string Company { get; set; }
        public string GlcontrolType { get; set; }
        public string BusinessEntity { get; set; }
        public string Glcrequirement { get; set; }
        public bool Needed { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
