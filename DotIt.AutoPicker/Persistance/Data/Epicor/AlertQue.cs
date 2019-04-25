using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Persistance.Data.Epicor
{
    public partial class AlertQue
    {
        public string Company { get; set; }
        public int Alertnum { get; set; }
        public int QueueNum { get; set; }
        public string Sender { get; set; }
        public string EmailAddr { get; set; }
        public string EmailCc { get; set; }
        public string AlertText { get; set; }
        public string Subject { get; set; }
        public string LinkParameters { get; set; }
        public string EmailFrom { get; set; }
        public string MimeHeader { get; set; }
        public string BodyType { get; set; }
        public int SendAttempts { get; set; }
        public DateTime? AlertDate { get; set; }
        public int AlertTime { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
