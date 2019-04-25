using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustomLayer
    {
        public CustomLayer()
        {
            ContextType = new HashSet<ContextType>();
        }

        public string CustomLayerId { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool SystemFlag { get; set; }

        public virtual ICollection<ContextType> ContextType { get; set; }
    }
}
