using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Acttype
    {
        public int ActtypeUid { get; set; }
        public string DisplayName { get; set; }
        public string Company { get; set; }
        public string DetailedDescription { get; set; }
        public bool Limited { get; set; }
        public bool IsLog { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool ConversionErrors { get; set; }
    }
}
