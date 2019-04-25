using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class JrnlCode
    {
        public string Company { get; set; }
        public string JournalCode { get; set; }
        public string JrnlDescription { get; set; }
        public bool SystemJournal { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
        public string Mxpolicy { get; set; }
        public bool AllowStatJournals { get; set; }
        public bool PetransferAndCancel { get; set; }
        public string Cnkeeper { get; set; }
        public string Cnmaker { get; set; }
        public string Cncashier { get; set; }
        public string Cnchecker { get; set; }
    }
}
