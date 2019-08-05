using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CrystalServer
    {
        public string Company { get; set; }
        public int ServerNum { get; set; }
        public string ServerName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public string CrystalType { get; set; }
        public string DbserverName { get; set; }
        public string DbcrystalName { get; set; }
        public string CrystalUserId { get; set; }
        public string Password { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
