using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class PurAuth
    {
        public string Company { get; set; }
        public string BuyerId { get; set; }
        public string DcdUserId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
