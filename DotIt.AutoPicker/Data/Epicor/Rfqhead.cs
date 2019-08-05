using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Rfqhead
    {
        public string Company { get; set; }
        public bool OpenRfq { get; set; }
        public int Rfqnum { get; set; }
        public DateTime? Rfqdate { get; set; }
        public DateTime? RfqdueDate { get; set; }
        public string BuyerId { get; set; }
        public string CommentText { get; set; }
        public bool ReadyToPrint { get; set; }
        public DateTime? RespondDate { get; set; }
        public DateTime? DecisionDate { get; set; }
        public bool PostToWeb { get; set; }
        public DateTime? PostDate { get; set; }
        public string GlbCompany { get; set; }
        public int GlbRfqnum { get; set; }
        public bool AutoPrintReady { get; set; }
        public string UomclassId { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
