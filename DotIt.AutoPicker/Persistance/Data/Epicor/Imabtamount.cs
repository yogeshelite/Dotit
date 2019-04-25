using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imabtamount
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int ActtypeUid { get; set; }
        public int ActrevisionUid { get; set; }
        public int AbtdocLineUid { get; set; }
        public int AbtamountUid { get; set; }
        public string Qualifier { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public string Company { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
