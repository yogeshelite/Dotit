using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class MktgPub
    {
        public string Company { get; set; }
        public string PublicationCode { get; set; }
        public string PubDescription { get; set; }
        public bool Inactive { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
