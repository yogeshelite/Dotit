using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class QueryFunctionCall
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public Guid SubQueryId { get; set; }
        public string FunctionId { get; set; }
        public string ParameterName { get; set; }
        public int Seq { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
