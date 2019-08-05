using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ParsingParam
    {
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
