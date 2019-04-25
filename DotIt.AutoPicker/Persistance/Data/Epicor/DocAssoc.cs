using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class DocAssoc
    {
        public string Company { get; set; }
        public string DocExtension { get; set; }
        public string Description { get; set; }
        public string ViewCommand { get; set; }
        public string PrintCommand { get; set; }
        public string DefaultPath { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public int CompanyVisibility { get; set; }
    }
}
