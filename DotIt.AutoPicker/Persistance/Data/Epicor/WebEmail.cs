using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class WebEmail
    {
        public string Company { get; set; }
        public string AppName { get; set; }
        public string MsgType { get; set; }
        public string Subject { get; set; }
        public string LangNameId { get; set; }
        public string Body { get; set; }
        public string SubstQryTables { get; set; }
        public string SubstQryFields { get; set; }
        public string SubstQryFormats { get; set; }
        public string SubstQryStr { get; set; }
        public string SubstStart { get; set; }
        public string SubstEnd { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
