using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Rating
    {
        public string Company { get; set; }
        public string RatingCode { get; set; }
        public int Precedence { get; set; }
        public bool GlobalRating { get; set; }
        public bool GlobalLock { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
