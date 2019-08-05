﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImglbRating
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Precedence { get; set; }
        public string RatingCode { get; set; }
        public string GlbCompany { get; set; }
        public string GlbRatingCode { get; set; }
        public bool Skipped { get; set; }
        public bool GlobalLock { get; set; }
        public bool GlobalRating { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
