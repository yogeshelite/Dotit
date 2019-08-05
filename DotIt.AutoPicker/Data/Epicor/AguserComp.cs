using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AguserComp
    {
        public string Company { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DfltInvPoint { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
