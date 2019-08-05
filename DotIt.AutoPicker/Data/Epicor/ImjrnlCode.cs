﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImjrnlCode
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
        public string JournalType { get; set; }
    }
}
