using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlcBatch
    {
        public string Company { get; set; }
        public string BatchId { get; set; }
        public string Description { get; set; }
        public string BookId { get; set; }
        public bool Reverse { get; set; }
        public string JournalCode { get; set; }
        public bool Cycle { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
