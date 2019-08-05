﻿using System;
using System.Collections.Generic;

namespace DotIt.AutoPicker.Data.Epicor
{
    public partial class ImalertLog
    {
        public int IntQueId { get; set; }
        public string IncomingOutgoing { get; set; }
        public string IntStatus { get; set; }
        public bool IntError { get; set; }
        public bool IntComplete { get; set; }
        public Guid IntSysRowId { get; set; }
        public DateTime? IntLastUpdated { get; set; }
        public string Company { get; set; }
        public int Alertnum { get; set; }
        public int ErrLogNum { get; set; }
        public string ErrorType { get; set; }
        public string Description { get; set; }
        public string EmailAddr { get; set; }
        public string EmailCc { get; set; }
        public string Sender { get; set; }
        public DateTime? SentDate { get; set; }
        public int SentTime { get; set; }
        public string AlertText { get; set; }
        public string EmailFromAddr { get; set; }
        public string EmailFromLabel { get; set; }
        public string MimeHeader { get; set; }
        public string ErrorText { get; set; }
        public DateTime? AlertDate { get; set; }
        public int AlertTime { get; set; }
        public string Plant { get; set; }
        public byte[] SysRevId { get; set; }
        public Guid SysRowId { get; set; }
    }
}
