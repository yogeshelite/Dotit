using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbPcLookupColSetDtl
    {
        public string Company { get; set; }
        public string LookupTblId { get; set; }
        public string ColSetId { get; set; }
        public string ColName { get; set; }
        public int SeqNum { get; set; }
        public string DataType { get; set; }
        public string ColFormat { get; set; }
        public string GlbCompany { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public bool AllowNegative { get; set; }
        public bool NumericOnly { get; set; }
        public bool UseSeparator { get; set; }
        public int Digits { get; set; }
        public int Decimals { get; set; }
    }
}
