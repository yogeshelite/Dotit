using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ZlookupField
    {
        public string SystemCode { get; set; }
        public string DataTableId { get; set; }
        public string LookupId { get; set; }
        public int Seq { get; set; }
        public string FieldName { get; set; }
        public bool IsConst { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual ZlookupLink ZlookupLink { get; set; }
    }
}
