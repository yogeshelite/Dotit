using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Zbodef
    {
        public Zbodef()
        {
            ImportDocument = new HashSet<ImportDocument>();
            ZbodataSets = new HashSet<ZbodataSets>();
        }

        public string SystemCode { get; set; }
        public string ClassName { get; set; }
        public string ObjectNs { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string ClassType { get; set; }
        public string RequiredModules { get; set; }
        public bool Complete { get; set; }
        public string Author { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool SystemFlag { get; set; }
        public bool AllowMultiRowUpdate { get; set; }
        public bool UseCurrentCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool HighVolumeImportEnabled { get; set; }

        public virtual Zsystem SystemCodeNavigation { get; set; }
        public virtual ICollection<ImportDocument> ImportDocument { get; set; }
        public virtual ICollection<ZbodataSets> ZbodataSets { get; set; }
    }
}
