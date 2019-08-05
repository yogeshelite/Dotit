using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class DashBdLike
    {
        public string Company { get; set; }
        public string ProductId { get; set; }
        public string GlbCompany { get; set; }
        public string DefinitionId { get; set; }
        public string LikeField { get; set; }
        public string Cgccode { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
