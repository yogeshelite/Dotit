using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class Subscriber
    {
        public string SubscriberId { get; set; }
        public string Status { get; set; }
        public byte CaptureCutoffDays { get; set; }
        public long Bookmark { get; set; }
    }
}
