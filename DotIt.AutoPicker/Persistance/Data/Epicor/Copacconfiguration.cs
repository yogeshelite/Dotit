using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Copacconfiguration
    {
        public string Company { get; set; }
        public string Copaccode { get; set; }
        public string TargetUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
    }
}
