using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class WebSessionTable
    {
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
