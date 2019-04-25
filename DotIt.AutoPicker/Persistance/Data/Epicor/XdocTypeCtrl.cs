using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class XdocTypeCtrl
    {
        public string Company { get; set; }
        public string TableName { get; set; }
        public string DocTypeId { get; set; }
        public bool ExposeInTree { get; set; }
        public bool RestrictToTable { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
