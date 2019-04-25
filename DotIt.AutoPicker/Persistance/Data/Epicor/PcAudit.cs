using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcAudit
    {
        public string Company { get; set; }
        public string PartNum { get; set; }
        public string RevisionNum { get; set; }
        public DateTime? ChgDate { get; set; }
        public int ChgTime { get; set; }
        public string ChgBy { get; set; }
        public string ChgDescription { get; set; }
        public string SourceDbrecid { get; set; }
        public string ConfigId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
