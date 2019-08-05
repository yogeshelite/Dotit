using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imabtqparam
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int BaqparamLinkUid { get; set; }
        public int AbtqueryUid { get; set; }
        public int ActrevisionUid { get; set; }
        public int ActtypeUid { get; set; }
        public string Company { get; set; }
        public string Baqparam { get; set; }
        public string Abtbaqparam { get; set; }
        public int AbtdocLineUid { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
