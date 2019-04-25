using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class GlbRating
    {
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
