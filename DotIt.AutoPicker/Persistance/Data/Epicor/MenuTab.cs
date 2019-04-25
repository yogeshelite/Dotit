using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class MenuTab
    {
        public string UserId { get; set; }
        public string TabCaption { get; set; }
        public int Type { get; set; }
        public string Content { get; set; }
        public int TabId { get; set; }
        public string CompanyId { get; set; }
        public string PlantId { get; set; }
        public string AppServerUrl { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
