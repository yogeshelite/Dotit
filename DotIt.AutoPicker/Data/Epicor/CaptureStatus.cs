using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CaptureStatus
    {
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public bool CaptureEnabled { get; set; }
    }
}
