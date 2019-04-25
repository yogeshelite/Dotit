using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Icever
    {
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
