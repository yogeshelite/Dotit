using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class Imrfqhead
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
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
