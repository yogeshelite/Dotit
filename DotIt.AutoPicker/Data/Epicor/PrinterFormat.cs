using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PrinterFormat
    {
        public string Company { get; set; }
        public string PrinterName { get; set; }
        public string OutputFormat { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
