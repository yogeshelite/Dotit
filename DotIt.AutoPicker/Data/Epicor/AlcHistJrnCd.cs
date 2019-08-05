using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class AlcHistJrnCd
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public string AllocId { get; set; }
        public int ParamNbr { get; set; }
        public int RunNbr { get; set; }
        public string BookId { get; set; }
        public int RunType { get; set; }
        public string JournalCode { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
