using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class GlbTable
    {
        public string Company { get; set; }
        public string TableName { get; set; }
        public string UseFieldList { get; set; }
        public string ExtSystemId { get; set; }
        public string ExtCompanyId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
