using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class CustomizationStore
    {
        public string Folder { get; set; }
        public string Assembly { get; set; }
        public string Version { get; set; }
        public string Info { get; set; }
        public byte[] Data { get; set; }
        public byte[] Symbols { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
