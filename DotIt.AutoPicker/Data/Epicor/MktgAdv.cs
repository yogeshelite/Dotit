using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MktgAdv
    {
        public string Company { get; set; }
        public string AdvertisementCode { get; set; }
        public string AdvertDescription { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
