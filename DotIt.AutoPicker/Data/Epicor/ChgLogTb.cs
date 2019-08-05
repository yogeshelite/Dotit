using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ChgLogTb
    {
        public string Company { get; set; }
        public string TableName { get; set; }
        public string UseFieldList { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
