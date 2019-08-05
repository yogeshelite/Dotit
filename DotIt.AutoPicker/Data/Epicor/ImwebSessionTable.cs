using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImwebSessionTable
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string SessId { get; set; }
        public string TableName { get; set; }
        public int RowNumber { get; set; }
        public string FieldName { get; set; }
        public int FieldExtent { get; set; }
        public string FieldData { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateTime { get; set; }
        public string SessSubId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
