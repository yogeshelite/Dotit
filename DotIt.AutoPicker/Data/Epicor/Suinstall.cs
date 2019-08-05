using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Suinstall
    {
        public string ServerName { get; set; }
        public string ApplicationName { get; set; }
        public string PackageName { get; set; }
        public string Version { get; set; }
        public DateTime? InstallDate { get; set; }
        public string Result { get; set; }
        public bool Installed { get; set; }
        public string UserId { get; set; }
        public string Machine { get; set; }
        public string Comment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
