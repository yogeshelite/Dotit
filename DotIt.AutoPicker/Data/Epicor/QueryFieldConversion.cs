using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryFieldConversion
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string TableId { get; set; }
        public string FieldName { get; set; }
        public string DataType { get; set; }
        public string FieldFormat { get; set; }
        public string Formula { get; set; }
        public string Location { get; set; }
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
