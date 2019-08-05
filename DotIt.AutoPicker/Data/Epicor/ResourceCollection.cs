using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ResourceCollection
    {
        public string Company { get; set; }
        public string CollectionId { get; set; }
        public string Description { get; set; }
        public string ResourceGroupList { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
