using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class TranDocTypeAuth
    {
        public string Company { get; set; }
        public string TranDocTypeId { get; set; }
        public int TranDocTypeAuthLine { get; set; }
        public string DcdUserId { get; set; }
        public string SystemTranId { get; set; }
        public bool DefaultTranDocType { get; set; }
        public bool FirstForUser { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
