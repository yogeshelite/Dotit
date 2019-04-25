using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class RptStructuredOutputFileXmlnamespace
    {
        public string Company { get; set; }
        public string RptStructuredOutputDefId { get; set; }
        public string RptStructuredOutputFileId { get; set; }
        public int RptStructuredOutputFileNamespaceId { get; set; }
        public string Namespace { get; set; }
        public string Prefix { get; set; }
        public bool SystemFlag { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual RptStructuredOutputFile RptStructuredOutput { get; set; }
    }
}
