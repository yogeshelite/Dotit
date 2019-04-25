using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ChgLog
    {
        public string Company { get; set; }
        public string Identifier { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public DateTime DateStampedOn { get; set; }
        public string LogText { get; set; }
        public int LogNum { get; set; }
        public string UserId { get; set; }
        public string ChgLogMethod { get; set; }
        public int ChgLogSeq { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
