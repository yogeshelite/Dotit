using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImxfileRef
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
