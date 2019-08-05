using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class EpuserDefinedTable
    {
        public string PackageId { get; set; }
        public string TableName { get; set; }
        public bool Selected { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
