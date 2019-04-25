using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImportDocument
    {
        public ImportDocument()
        {
            ImportKeyValueStore = new HashSet<ImportKeyValueStore>();
            ImportTask = new HashSet<ImportTask>();
        }

        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public long DocumentNumber { get; set; }
        public string SystemCode { get; set; }
        public string ClassName { get; set; }
        public string DocumentType { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ImportFile ImportFile { get; set; }
        public virtual Zbodef Zbodef { get; set; }
        public virtual ICollection<ImportKeyValueStore> ImportKeyValueStore { get; set; }
        public virtual ICollection<ImportTask> ImportTask { get; set; }
    }
}
