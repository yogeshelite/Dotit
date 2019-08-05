using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Editrnsl
    {
        public string Company { get; set; }
        public string Name { get; set; }
        public string TranslatorId { get; set; }
        public string ExportProgram { get; set; }
        public string ImportFile { get; set; }
        public string CustSupportNum { get; set; }
        public string Contact { get; set; }
        public string SerialNumber { get; set; }
        public string ExportFile { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
