using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DataExportHistory
    {
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public int ICounter { get; set; }
        public string Action { get; set; }
        public DateTime? ActionDate { get; set; }
        public string UserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
