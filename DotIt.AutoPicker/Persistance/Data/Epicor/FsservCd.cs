using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class FsservCd
    {
        public string Company { get; set; }
        public string ServCode { get; set; }
        public string ServDescription { get; set; }
        public string CommentText { get; set; }
        public decimal LaborRate { get; set; }
        public decimal EstLabHours { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
