using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FavFolder
    {
        public FavFolder()
        {
            FavItems = new HashSet<FavItems>();
        }

        public string UserId { get; set; }
        public int FolderSeq { get; set; }
        public string Description { get; set; }
        public int Ypos { get; set; }
        public bool AutoLoadContents { get; set; }
        public bool AutoLoadSessionChange { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual SysUserFile User { get; set; }
        public virtual ICollection<FavItems> FavItems { get; set; }
    }
}
