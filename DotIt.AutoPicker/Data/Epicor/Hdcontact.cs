using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Hdcontact
    {
        public string Company { get; set; }
        public int HdcaseNum { get; set; }
        public Guid PerConLnkRowId { get; set; }
        public bool Primary { get; set; }
        public string Comment { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool Requestor { get; set; }
    }
}
