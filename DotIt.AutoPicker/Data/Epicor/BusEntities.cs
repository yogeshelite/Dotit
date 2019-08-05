using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class BusEntities
    {
        public string Company { get; set; }
        public string BusinessEntity { get; set; }
        public string Description { get; set; }
        public bool Coaentity { get; set; }
        public string SegValueField { get; set; }
        public string DescFieldName { get; set; }
        public string EntityType { get; set; }
        public bool GlcontrolEntity { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
