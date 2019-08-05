using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImdataExportTable
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string DefinitionId { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
        public string FileName { get; set; }
        public string GenerateMethod { get; set; }
        public string DataSource { get; set; }
        public string DataSourceId { get; set; }
        public string ExportFileType { get; set; }
        public bool IncludeHeader { get; set; }
        public string Dsymbol { get; set; }
        public string ExportMethod { get; set; }
        public int TableOrder { get; set; }
        public string AddHeader { get; set; }
        public string AddFooter { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
