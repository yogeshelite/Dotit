using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class XfileRef
    {
        public string Company { get; set; }
        public int XfileRefNum { get; set; }
        public string XfileName { get; set; }
        public string PdmdocId { get; set; }
        public string XfileDesc { get; set; }
        public string DocTypeId { get; set; }
        public string BaseFileName { get; set; }
        public string ExternalSystemDoc { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
