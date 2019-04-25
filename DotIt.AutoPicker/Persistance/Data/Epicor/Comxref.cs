using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Comxref
    {
        public string Company { get; set; }
        public string File { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public string ForeignKey1 { get; set; }
        public string ForeignKey2 { get; set; }
        public string ForeignKey3 { get; set; }
        public string ForeignKey4 { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
