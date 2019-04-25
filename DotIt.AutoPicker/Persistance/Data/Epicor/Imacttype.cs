using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Imacttype
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public int ActtypeUid { get; set; }
        public string DisplayName { get; set; }
        public string Company { get; set; }
        public string DetailedDescription { get; set; }
        public bool Limited { get; set; }
        public bool IsLog { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ConversionErrors { get; set; }
    }
}
