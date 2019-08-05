using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Xxxchunk
    {
        public string Company { get; set; }
        public string ProductId { get; set; }
        public string TypeCode { get; set; }
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public string Key3 { get; set; }
        public int SeqNum { get; set; }
        public string Chunk { get; set; }
        public string Cgccode { get; set; }
        public bool SystemFlag { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
