﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imustinvalidation
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public string TinvalidationId { get; set; }
        public string Description { get; set; }
        public int EftheadUid { get; set; }
        public string ExportFile { get; set; }
        public bool Submitted { get; set; }
        public bool Exported { get; set; }
        public bool IncludeValidStatusNew { get; set; }
        public bool IncludeValidStatusInvalid { get; set; }
        public bool IncludeValidStatusPending { get; set; }
        public bool IncludeValidStatusMatched { get; set; }
        public string TrackingNumber { get; set; }
        public bool ResultReceived { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}