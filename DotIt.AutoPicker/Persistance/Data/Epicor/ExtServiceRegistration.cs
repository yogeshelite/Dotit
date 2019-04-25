using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ExtServiceRegistration
    {
        public string ServiceId { get; set; }
        public string ServerName { get; set; }
        public bool IsRunning { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
