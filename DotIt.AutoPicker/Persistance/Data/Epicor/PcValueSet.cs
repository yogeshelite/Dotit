using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class PcValueSet
    {
        public string Company { get; set; }
        public int GroupSeq { get; set; }
        public int HeadNum { get; set; }
        public int PageSeq { get; set; }
        public int ValueSetSeq { get; set; }
        public string ConfigId { get; set; }
        public string InputName { get; set; }
        public int DisplaySeq { get; set; }
        public string FieldValues { get; set; }
        public string FieldProperties { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
