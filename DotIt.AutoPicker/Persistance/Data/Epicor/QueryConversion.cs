using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class QueryConversion
    {
        public string Company { get; set; }
        public string QueryId { get; set; }
        public string StatusCode { get; set; }
        public string StatusText { get; set; }
        public string Origin { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
