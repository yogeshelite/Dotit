using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ThemeBackup
    {
        public string ThemeId { get; set; }
        public string ThemeDesc { get; set; }
        public bool DefaultFlag { get; set; }
        public bool DistributableFlag { get; set; }
        public string ThemeXml { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string LastUpdatedBy { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
