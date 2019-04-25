using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Prclass
    {
        public string Company { get; set; }
        public string ClassId { get; set; }
        public string Description { get; set; }
        public string AuthorizedUsers { get; set; }
        public string CheckSum { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
