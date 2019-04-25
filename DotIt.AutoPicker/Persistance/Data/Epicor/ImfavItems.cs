using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class ImfavItems
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
    }
}
