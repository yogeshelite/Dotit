using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptStructuredOutputFile
    {
        public RptStructuredOutputFile()
        {
            RptStructuredOutputFileElement = new HashSet<RptStructuredOutputFileElement>();
            RptStructuredOutputFileXmlnamespace = new HashSet<RptStructuredOutputFileXmlnamespace>();
        }

        public string Company { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public string RptStructuredOutputFileId { get; set; }
        public string RptStructuredOutputFileDesc { get; set; }
        public bool Enabled { get; set; }
        public int StructuredOutputFileType { get; set; }
        public string OutputLocation { get; set; }
        public bool OutputColumnHeaders { get; set; }
        public string AdditionalSettings { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptStructuredOutputDef RptStructuredOutputDef { get; set; }
        public virtual ICollection<RptStructuredOutputFileElement> RptStructuredOutputFileElement { get; set; }
        public virtual ICollection<RptStructuredOutputFileXmlnamespace> RptStructuredOutputFileXmlnamespace { get; set; }
    }
}
