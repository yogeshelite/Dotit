using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ExtSysTable
    {
        public ExtSysTable()
        {
            ExtSysTableChild = new HashSet<ExtSysTableChild>();
            ExtSysTableKey = new HashSet<ExtSysTableKey>();
        }

        public string ExtSystemId { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ImtableName { get; set; }
        public string InOutNeitherBoth { get; set; }
        public string DcrmterrProgram { get; set; }
        public bool DcrmengineerOnly { get; set; }
        public string DcrmfunctionalGroup { get; set; }
        public bool IncludeBeforeImage { get; set; }
        public string TransferMethod { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string ExtSysCharacter01 { get; set; }
        public string ExtSysCharacter02 { get; set; }
        public bool ExtSysBoolean01 { get; set; }
        public bool ExtSysBoolean02 { get; set; }
        public DateTime? ExtSysDateTime01 { get; set; }
        public DateTime? ExtSysDateTime02 { get; set; }
        public string OutboundActionOnDelete { get; set; }
        public string OutboundActionOnWrite { get; set; }
        public string FilterColumnName { get; set; }

        public virtual ICollection<ExtSysTableChild> ExtSysTableChild { get; set; }
        public virtual ICollection<ExtSysTableKey> ExtSysTableKey { get; set; }
    }
}
