using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImportFile
    {
        public ImportFile()
        {
            ImportDocument = new HashSet<ImportDocument>();
        }

        public string Company { get; set; }
        public long GroupId { get; set; }
        public long FileId { get; set; }
        public string Comments { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
        public string UploadStatus { get; set; }
        public int? NumberOfDocuments { get; set; }
        public bool ContinueProcessingOnError { get; set; }
        public bool RollbackParentOnChildError { get; set; }
        public bool RunSynchronously { get; set; }
        public string OverrideCompany { get; set; }
        public string OverridePlant { get; set; }
        public string OverrideLanguage { get; set; }
        public string OverrideFormatCulture { get; set; }
        public string OverrideSchemaName { get; set; }
        public string ImportSettings { get; set; }
        public string Formatter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string FormatName { get; set; }

        public virtual ImportGroup ImportGroup { get; set; }
        public virtual ICollection<ImportDocument> ImportDocument { get; set; }
    }
}
