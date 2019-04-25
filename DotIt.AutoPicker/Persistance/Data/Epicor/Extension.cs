using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Extension
    {
        public Guid ExtensionSetRowId { get; set; }
        public string InterceptType { get; set; }
        public string ImplementationType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ExtensionSet ExtensionSetRow { get; set; }
    }
}
