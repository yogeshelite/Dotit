using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExternalFileVersion
    {
        public string Company { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
