using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class FavItems
    {
        public string UserId { get; set; }
        public int FolderSeq { get; set; }
        public int ItemSeq { get; set; }
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string MenuName { get; set; }
        public int Ypos { get; set; }
        public string AppServerUrl { get; set; }
        public string CompanyId { get; set; }
        public string PlantId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }

        public virtual FavFolder FavFolder { get; set; }
    }
}
