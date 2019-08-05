using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imicever
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SystemCode { get; set; }
        public string SystemVersion { get; set; }
        public DateTime? SystemDate { get; set; }
        public string DbschemaVersion { get; set; }
        public DateTime? DbschemaDate { get; set; }
        public string PatchVersion { get; set; }
        public DateTime? PatchDate { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public decimal? ReleaseOrder { get; set; }
        public bool PendingConversion { get; set; }
    }
}
