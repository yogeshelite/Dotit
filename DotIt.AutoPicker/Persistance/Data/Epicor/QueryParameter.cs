using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryParameter
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string ParameterId { get; set; }
        public string ParameterType { get; set; }
        public string ParameterLabel { get; set; }
        public bool SkipIfEmpty { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
