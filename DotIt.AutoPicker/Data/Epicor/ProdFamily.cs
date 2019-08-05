using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ProdFamily
    {
        public string Company { get; set; }
        public string ProdFamilyId { get; set; }
        public string Description { get; set; }
        public bool GlobalProdFamily { get; set; }
        public bool GlobalLock { get; set; }
        public string CommentText { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
