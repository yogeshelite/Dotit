using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImparsingParam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string ParamCode { get; set; }
        public string Description { get; set; }
        public int BlockLength { get; set; }
        public string BlockSeparator { get; set; }
        public bool BlockSwitch { get; set; }
        public int EndCharPos { get; set; }
        public string EndKeyword { get; set; }
        public bool EndSwitch { get; set; }
        public string RegExp { get; set; }
        public int StartCharPos { get; set; }
        public string StartKeyword { get; set; }
        public bool StartSwitch { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
