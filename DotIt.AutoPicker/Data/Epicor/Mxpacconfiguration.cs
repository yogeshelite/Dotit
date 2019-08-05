using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Mxpacconfiguration
    {
        public string Company { get; set; }
        public string Mxpaccode { get; set; }
        public string TargetUrl { get; set; }
        public string X509code { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
