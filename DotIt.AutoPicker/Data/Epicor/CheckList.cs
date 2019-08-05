using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class CheckList
    {
        public string Company { get; set; }
        public string ListId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string CommentText { get; set; }
        public string LinkListId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
