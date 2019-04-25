using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ResourceType
    {
        public string Company { get; set; }
        public string ResourceTypeId { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string ExternalMestype { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
