using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcJrnCd
    {
        public string Company { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public string JournalCode { get; set; }
        public string BookId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
